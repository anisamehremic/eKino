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
    public partial class UlaznicePage : ContentPage
    {
        UlazniceViewModel model = null;
        public UlaznicePage()
        {
            InitializeComponent();
            BindingContext = model = new UlazniceViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajUlaznice();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var ulaznica = e.SelectedItem as Model.Ulaznice;
            await Navigation.PushAsync(new DetaljiUlaznicePage(ulaznica));
        }
    }
}