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
    public class RegistracijaViewModel:BaseViewModel
    {
        private readonly APIService _registracija = new APIService("Registracija");
        private readonly APIService _gledaoci = new APIService("Gledaoci");

        public RegistracijaViewModel()
        {
            PrijaviSeCommand = new Command(()=> PrijaviSe());
        }
        public ICommand RegistracijaCommand { get; set; }
        public ICommand PrijaviSeCommand { get; set; }
        public void PrijaviSe() {
            Application.Current.MainPage = new LoginPage();
        }
        public async Task Registracija()
        {
            GledaociUpsertRequest request = new GledaociUpsertRequest()
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                KorisnickoIme = KorisnickoIme,
                DatumRodjenja = DatumRodjenja,
                Sifra = Sifra,
                SifraPotvrda = SifraPotvrda,
                Telefon = Telefon,
                Status=true
            };
            try
            {
                var result = await _registracija.Insert<Model.Gledaoci>(request);
                Application.Current.MainPage = new LoginPage();
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste unijeli ispravne podatke.", "OK");
            }
        }

        public async Task<bool> PostojiKorisnickoIme(string KorisnickoIme)
        {
            var gledaoci = await _registracija.Get<List<Model.Gledaoci>>(null);
            foreach (var item in gledaoci)
            {
                if (item.KorisnickoIme == KorisnickoIme)
                    return true;
            }
            return false;
        }

        public async Task<bool> PostojiEmail(string Email)
        {
            var gledaoci = await _registracija.Get<List<Model.Gledaoci>>(null);
            foreach (var item in gledaoci)
            {
                if (item.Email == Email)
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

        DateTime _datumRodjenja=DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }

    }
}
