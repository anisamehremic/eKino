using eKino.Mobile.Views;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class OcijeniFilmViewModel:BaseViewModel
    {
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        private readonly APIService _ocjene = new APIService("Ocjene");

        Model.Rezervacije rezervacija = null;
        public OcijeniFilmViewModel()
        {
        }
        public OcijeniFilmViewModel(Model.Rezervacije r)
        {
            rezervacija = r;
        }
       public async Task OcijeniFilm(string ocjena)
       {
            if (rezervacija.Projekcija.DatumVrijemeOdrzavanja > DateTime.Now)
            {
                await Application.Current.MainPage.DisplayAlert("Upozorenje", "Vrijeme prikazivanja projekcije nije isteklo.", "OK");
                return;
            }
            int Ocjena = int.Parse(ocjena);
            GledaociSearchRequest request1 = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request1);
            var gledalac = listaGledaoci[0].GledalacId;

            var ocjene = await _ocjene.Get<List<Model.Ocjene>>(null);
            bool ima = false;
            foreach(var item in ocjene)
            {
                if(item.GledalacId==gledalac && rezervacija.Projekcija.FilmId == item.FilmId)
                {
                    ima = true;
                    break;
                }
            }
            if (!ima)
            {
                OcjeneUpsertRequest request = new OcjeneUpsertRequest()
                {
                    DatumOcjenjivanja = DateTime.Now,
                    FilmId = rezervacija.Projekcija.FilmId,
                    Ocjena = Ocjena,
                    GledalacId = gledalac
                };
                if (Ocjena == 1 || Ocjena == 2 || Ocjena == 3 || Ocjena == 4 || Ocjena == 5)
                {
                    await _ocjene.Insert<Model.Ocjene>(request);
                    await Application.Current.MainPage.DisplayAlert("Ocjena filma", "Uspješno ste ocijenili film.", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Niste unijeli odgovarajuću ocjenu.", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Upozorenje", "Već ste ocijenili odabrani film.", "OK");
            }
        }

        int _ocjena;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
    }
}
