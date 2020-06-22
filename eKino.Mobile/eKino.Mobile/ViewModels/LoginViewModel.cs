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
    public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _services=new APIService("Uloge");
        private readonly APIService _gledaoci=new APIService("Gledaoci");

        string _password = null;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        string _username = null;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public ICommand LoginCommand { get; set; }
        public ICommand RegistracijaCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async() => await Login());
            RegistracijaCommand= new Command(() => Registracija());
        }
        public void Registracija()
        {
            Application.Current.MainPage = new RegistracijaPage();
        }
        public async Task Login() {
            APIService.Username = Username;
            APIService.Password = Password;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Obavezno polje", "Obavezan unos korisničkog imena i šifre", "OK");
                return;
            }
            else
            {

                try
                {
                    await _services.Get<dynamic>(null);
                    var gledaocList = await _gledaoci.Get<List<Model.Gledaoci>>(new GledaociSearchRequest() { Username = APIService.Username});
                    if (gledaocList.Count == 1)
                    {
                        Application.Current.MainPage = new MainPage();
                    }
                    else {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešno uneseno korisničko ime ili šifra.", "OK");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešno uneseno korisničko ime ili šifra.", "OK");
                    return;
                }
            }
        }
    }
}
