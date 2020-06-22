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
    public class DetaljiRezervacijeViewModel:BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        Model.Rezervacije r = null;
        public DetaljiRezervacijeViewModel()
        {

        }
        public DetaljiRezervacijeViewModel(Model.Rezervacije rezervacija=null)
        {
            r = rezervacija;
            UcitajPodatkeCommand = new Command(async()=>await UcitajPodatke());
            OtkaziRezervacijuCommand = new Command(async()=>await OtkaziRezervaciju());
        }

        public ICommand UcitajPodatkeCommand { get; set; }
        public ICommand OtkaziRezervacijuCommand { get; set; }
        public async Task UcitajPodatke()
        {
            var rezervacija = await _rezervacije.GetById<Model.Rezervacije>(r.RezervacijaId);
            Film = rezervacija.Projekcija.Film.Naziv;
            Slika = rezervacija.Projekcija.Film.Slika;
            Sala = rezervacija.Projekcija.Sala.Naziv;
            VrijemePrikazivanja = rezervacija.Projekcija.DatumVrijemeOdrzavanja.ToString();
            Rezervacija = rezervacija;
        }
        public async Task OtkaziRezervaciju()
        {
            var razlika = (int)(DateTime.Now - r.DatumRezervacije).TotalDays;
            if (razlika > 3)
            {
                await Application.Current.MainPage.DisplayAlert("Otkazivanje rezeracije", "Isteklo vrijeme za otkazivanje rezervacije", "OK");
            }
            else
            {
                var ulaznice = await _ulaznice.Get<List<Model.Ulaznice>>(null);
                foreach (var item in ulaznice)
                {
                    if (item.Status && item.RezervacijaId == r.RezervacijaId)
                    {
                        UlazniceUpsertRequest request = new UlazniceUpsertRequest()
                        {
                            ProjekcijaId = item.ProjekcijaId,
                            Cijena = item.Cijena,
                            Qrcode = item.Qrcode,
                            RezervacijaId = item.RezervacijaId,
                            SjedisteId = item.SjedisteId,
                            Status = false
                        };
                        await _ulaznice.Update<Model.Ulaznice>(item.UlaznicaId, request);
                    }
                }
                RezervacijeUpsertRequest request2 = new RezervacijeUpsertRequest()
                {
                    Status = false,
                    BrojKarata = r.BrojKarata,
                    Cijena = r.Cijena,
                    DatumRezervacije = r.DatumRezervacije,
                    GledalacId = r.GledalacId,
                    ProjekcijaId = r.ProjekcijaId,
                    mobilna = true
                };
                await _rezervacije.Update<Model.Rezervacije>(r.RezervacijaId, request2);
                await Application.Current.MainPage.DisplayAlert("Otkazivanje rezervacije", "Uspješno ste otkazali rezervaciju.", "OK");
            }
        }

        string _film = string.Empty;
        public string Film
        {
            get { return _film; }
            set { SetProperty(ref _film, value);}
        }

        string _sala = string.Empty;
        public string Sala
        {
            get { return _sala; }
            set { SetProperty(ref _sala, value); }
        }

        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        string _vrijemePrikazivanja = string.Empty;
        public string VrijemePrikazivanja
        {
            get { return _vrijemePrikazivanja; }
            set { SetProperty(ref _vrijemePrikazivanja, value); }
        }

        Model.Rezervacije _rezervacija = null;
        public Model.Rezervacije Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }

    }
}
