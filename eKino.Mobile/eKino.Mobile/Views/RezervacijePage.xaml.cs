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
    public partial class RezervacijePage : ContentPage
    {
        RezervacijeViewModel model = null;
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var rezervacija = e.SelectedItem as Model.Rezervacije;
            await Navigation.PushAsync(new DetaljiRezervacijePage(rezervacija));
        }
    }
}