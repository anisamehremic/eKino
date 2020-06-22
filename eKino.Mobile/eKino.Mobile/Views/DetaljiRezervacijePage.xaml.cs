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
    public partial class DetaljiRezervacijePage : ContentPage
    {
        DetaljiRezervacijeViewModel model = null;
        public DetaljiRezervacijePage(Model.Rezervacije rezervacija)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiRezervacijeViewModel(rezervacija);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajPodatke();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var item = ((Button)sender).BindingContext as Model.Rezervacije;
            await Navigation.PushAsync(new OcijeniFilmPage(item));
        }
    }
}