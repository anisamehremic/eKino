using eKino.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class OdjaviSeViewModel
    {
        public OdjaviSeViewModel()
        {
        }
        public void Odjava()
        {
            APIService.Username = string.Empty;
            APIService.Password = string.Empty;
            Application.Current.MainPage = new LoginPage();
        } 
    }
}
