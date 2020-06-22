using eKino.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojiPodaciPage : ContentPage
    {
        MojiPodaciViewModel model = null;
        public MojiPodaciPage()
        {
            InitializeComponent();
            BindingContext = model = new MojiPodaciViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Ucitaj();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool ima = false; ;
            if (string.IsNullOrEmpty(Ime.Text))
            {
                Ime.Placeholder = "Obavezan unos!";
                Ime.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(Prezime.Text))
            {
                Prezime.Placeholder = "Obavezan unos!";
                Prezime.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(KorisnickoIme.Text))
            {
                KorisnickoIme.Placeholder = "Obavezan unos!";
                KorisnickoIme.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(Email.Text))
            {
                Email.Placeholder = "Obavezan unos!";
                Email.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(Telefon.Text))
            {
                Telefon.Placeholder = "Obavezan unos!";
                Telefon.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(TrenutnaSifra.Text))
            {
                TrenutnaSifra.Placeholder = "Obavezan unos!";
                TrenutnaSifra.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(Sifra.Text))
            {
                Sifra.Placeholder = "Obavezan unos!";
                Sifra.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (string.IsNullOrEmpty(SifraPotvrda.Text))
            {
                SifraPotvrda.Placeholder = "Obavezan unos!";
                SifraPotvrda.PlaceholderColor = Color.Red;
                ima = true;
            }
            if (!ima)
            {
                bool uredu = true;
                if (await model.PostojiKorisnickoIme(KorisnickoIme.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Korisničko ime već postoji", "OK");
                    KorisnickoIme.Text = "Korisničko ime već postoji";
                    uredu = false;
                }
                if (await model.PostojiEmail(Email.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Email već postoji", "OK");
                    uredu = false;
                }
                if (SifraPotvrda.Text != Sifra.Text) {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Šifre se razlikuju", "OK");
                    uredu = false;
                }
                if (APIService.Password != TrenutnaSifra.Text) {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Pogrešna trenutna šifra", "OK");
                    uredu = false;
                }
                if (uredu)
                {
                    await model.Sacuvaj();
                }
            }
        }
    }
}