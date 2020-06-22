using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class MojiPodaciViewModel:BaseViewModel
    {
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        public MojiPodaciViewModel()
        {
            UcitajPodatke = new Command(async()=>await Ucitaj());
        }
        public ICommand UcitajPodatke { get; set; }
        public async Task Ucitaj()
        {
            var gledaoci2 = await _gledaoci.Get<List<Model.Gledaoci>>(null);//da zadrži nit učitavanja stranice
            var gledaoci3 = await _gledaoci.Get<List<Model.Gledaoci>>(null);//da zadrži nit učitavanja stranice
            GledaociSearchRequest request = new GledaociSearchRequest() { 
            Username=APIService.Username
            };
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request);
                Ime = gledaoci[0].Ime;
                Prezime = gledaoci[0].Prezime;
                Telefon = gledaoci[0].Telefon;
                Email = gledaoci[0].Email;
                KorisnickoIme = gledaoci[0].KorisnickoIme;
                DatumRodjenja = gledaoci[0].DatumRodjenja;
        }
        public async Task Sacuvaj()
        {
            GledaociSearchRequest request1 = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request1);
            GledaociUpsertRequest request2 = new GledaociUpsertRequest()
            {
                Ime=Ime,
                Prezime=Prezime,
                DatumRodjenja=DatumRodjenja,
                Email=Email,
                KorisnickoIme=KorisnickoIme,
                Telefon=Telefon,
                StaraSifra=StaraSifra,
                Sifra=Sifra,
                SifraPotvrda=SifraPotvrda,
                Status=true,
                Mobilna=true
            };
            try {
               var result = await _gledaoci.Update<Model.Gledaoci>(gledaoci[0].GledalacId,request2);
               APIService.Username = request2.KorisnickoIme;
               APIService.Password = request2.Sifra;
               await Application.Current.MainPage.DisplayAlert("Uređivanje podataka", "Uspješno promijenjeno.", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Uređivanje podataka", "Niste unijeli ispravne podatke.", "OK");
            }
        }

        public async Task<bool> PostojiKorisnickoIme(string KorisnickoIme)
        {
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(null);
            var trenutni = await _gledaoci.Get<List<Model.Gledaoci>>(new GledaociSearchRequest() { Username = APIService.Username});
            foreach (var item in gledaoci)
            {
                if (item.KorisnickoIme == KorisnickoIme && item.GledalacId != trenutni[0].GledalacId)
                    return true;
            }
            return false;
        }

        public async Task<bool> PostojiEmail(string Email)
        {
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(null);
            var trenutni = await _gledaoci.Get<List<Model.Gledaoci>>(new GledaociSearchRequest() { Username = APIService.Username });
            foreach (var item in gledaoci)
            {
                if (item.Email == Email && item.GledalacId != trenutni[0].GledalacId)
                    return true;
            }
            return false;
        }

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }


        string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        string _staraSifra = string.Empty;
        public string StaraSifra
        {
            get { return _staraSifra; }
            set { SetProperty(ref _staraSifra, value); }
        }
        string _sifra = string.Empty;
        public string Sifra
        {
            get { return _sifra; }
            set { SetProperty(ref _sifra, value); }
        }

        string _sifraPotvrda = string.Empty;
        public string SifraPotvrda
        {
            get { return _sifraPotvrda; }
            set { SetProperty(ref _sifraPotvrda, value); }
        }

        DateTime _datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }
    }
}
