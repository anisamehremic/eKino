using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class SjedistaViewModel : BaseViewModel
    {
        private APIService _sjedista = new APIService("Sjedista");
        private APIService _gledaoci = new APIService("Gledaoci");
        private APIService _ulaznice = new APIService("Ulaznice");
        private APIService _projekcije = new APIService("Projekcije");
        private APIService _rezervacije = new APIService("Rezervacije");
        Model.Rezervacije rezervacija = null;
        public SjedistaViewModel()
        {

        }
        public SjedistaViewModel(Model.Rezervacije r)
        {
            InitCommand = new Command(async () => await Init());
            rezervacija = r;
        }
        public ObservableCollection<Model.Sjedista> SjedistaList { get; set; } = new ObservableCollection<Model.Sjedista>();

        public Ulaznice Ulaznica { get; set; }
        public Gledaoci Gledalac { get; set; }
        public Sale Sala { get; set; }

        public int BrojSjedista { get; set; }

        public int BrojKolona { get; set; }
        public int BrojRedova { get; set; }

        public ICommand InitCommand { get; set; }
        public List<Ulaznice> UlazniceList { get; set; }

        public async void NapraviRezervaciju(string redKolona, int projekcijaId)
        {
            var projekcija = await _projekcije.GetById<Model.Projekcije>(projekcijaId);

            SjedistaSearchRequest search = new SjedistaSearchRequest
            {
                SalaId = projekcija.SalaId
            };
            var sjedista = await _sjedista.Get<List<Model.Sjedista>>(search);
            int sjedisteId = 0;
            foreach (var item in sjedista)
            {
                if (item.Red + item.Kolona == redKolona)
                {
                    sjedisteId = item.SjedisteId;
                    break;
                }
            }


            //provjera da li je sjedište zauzeto
            var ulaznice = await _ulaznice.Get<List<Model.Ulaznice>>(null);
            bool zauzeto = false;
            foreach (var item in ulaznice)
            {
                if (item.ProjekcijaId == projekcija.ProjekcijaId && item.SjedisteId == sjedisteId && item.Status)
                {
                    zauzeto = true;
                    break;
                }
            }
            if (zauzeto)
            {
                await Application.Current.MainPage.DisplayAlert("Rezervacija", "Sjedište je zauzeto. Molimo pokušajte ponovo.", "OK");
            }
            else
            {

                GledaociSearchRequest request = new GledaociSearchRequest()
                {
                    Username = APIService.Username
                };
                var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request);
                var gledalac = listaGledaoci[0].GledalacId;



                //provjera da li je gledalac već rezervsao, ako jeste samo će se uvećati broj karata i dodati nova ulaznica
                var rezervacije = await _rezervacije.Get<List<Model.Rezervacije>>(null);
                bool rezervisao = false;
                int rezervacijaPostojeca = 0;
                int brojKarataPostojeca = 0;
                foreach (var item in rezervacije)
                {
                    if (item.GledalacId == gledalac && item.ProjekcijaId == projekcija.ProjekcijaId && item.Status == true)
                    {
                        rezervisao = true;
                        rezervacijaPostojeca = item.RezervacijaId;
                        brojKarataPostojeca = item.BrojKarata;
                    }
                }
                /////////////////////////////////////////////////////////////////////////////////////



                if (!rezervisao)
                {
                    RezervacijeUpsertRequest request2 = new RezervacijeUpsertRequest()
                    {
                        BrojKarata = 1,
                        Cijena = projekcija.Cijena,
                        DatumRezervacije = DateTime.Now,
                        GledalacId = gledalac,
                        ProjekcijaId = projekcija.ProjekcijaId,
                        Status = true,
                        mobilna = true
                    };

                    var r = await _rezervacije.Insert<Model.Rezervacije>(request2);
                    UlazniceUpsertRequest request3 = new UlazniceUpsertRequest()
                    {
                        GledalacId=gledalac,
                        Cijena = projekcija.Cijena,
                        ProjekcijaId = projekcija.ProjekcijaId,
                        RezervacijaId = r.RezervacijaId,
                        Status = true,
                        SjedisteId = sjedisteId,
                        QRtekst =
                        $"{listaGledaoci[0].Ime + " " + listaGledaoci[0].Prezime + "\n" + "Film: " + projekcija.Film.Naziv + "\n" + "Sala: " + projekcija.Sala.Naziv + "\n" + "Vrijeme prikazivanja projekcije: " + projekcija.DatumVrijemeOdrzavanja}"
                    };
                    await _ulaznice.Insert<Model.Ulaznice>(request3);
                    await Application.Current.MainPage.DisplayAlert("Rezervacija", "Uspješno ste rezervisali ulaznicu. Ulaznicu/e možete pogledati u sekciji 'Ulaznice'", "OK");
                }
                else
                {
                    RezervacijeUpsertRequest requestUrediRezervaciju = new RezervacijeUpsertRequest()
                    {
                        Cijena = projekcija.Cijena * (brojKarataPostojeca + 1),
                        DatumRezervacije = DateTime.Now,
                        GledalacId = gledalac,
                        ProjekcijaId = projekcija.ProjekcijaId,
                        Status = true,
                        BrojKarata = brojKarataPostojeca + 1,
                        mobilna = true
                    };
                    var r = await _rezervacije.Update<Model.Rezervacije>(rezervacijaPostojeca, requestUrediRezervaciju);
                    UlazniceUpsertRequest request3 = new UlazniceUpsertRequest()
                    {
                        GledalacId=gledalac,
                        Cijena = projekcija.Cijena,
                        ProjekcijaId = projekcija.ProjekcijaId,
                        RezervacijaId = r.RezervacijaId,
                        Status = true,
                        SjedisteId = sjedisteId,
                        QRtekst = $"{listaGledaoci[0].Ime + " " + listaGledaoci[0].Prezime + "\n" + "Film: " + projekcija.Film.Naziv + "\n" + "Sala: " + projekcija.Sala.Naziv + "\n" + "Vrijeme prikazivanja projekcije: " + projekcija.DatumVrijemeOdrzavanja}"
                    };
                    await _ulaznice.Insert<Model.Ulaznice>(request3);
                    await Application.Current.MainPage.DisplayAlert("Rezervacija", "Uspješno ste rezervisali ulaznicu. Ulaznicu/e možete pogledati u sekciji 'Ulaznice'", "OK");
                }
            }
        }

        public async Task Init()
        {
            IsBusy = true;
            var username = APIService.Username;
            List<Gledaoci> gledaoci = await _gledaoci.Get<List<Gledaoci>>(null);
            foreach (var item in gledaoci)
            {
                if (item.KorisnickoIme == username)
                {
                    Gledalac = item;
                    break;
                }
            }
            var projekcija = await _projekcije.GetById<Model.Projekcije>(rezervacija.ProjekcijaId);
            SjedistaSearchRequest request = new SjedistaSearchRequest()
            {
                SalaId = projekcija.SalaId
            };
            var list = await _sjedista.Get<List<Sjedista>>(request);
            BrojSjedista = 0;
            SjedistaList.Clear();
            foreach (var sjedalo in list)
            {

                SjedistaList.Add(sjedalo);
                BrojSjedista++;

            }
            if (BrojSjedista > 6)
                BrojRedova = BrojSjedista / 6;
            else
                BrojRedova = 1;

            UlazniceList = await _ulaznice.Get<List<Ulaznice>>(null);
            IsBusy = false;
        }
    }
}
