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
    public partial class NovostiPage : ContentPage
    {
        NovostiViewModel model = null;
        public NovostiPage()
        {
            InitializeComponent();
            BindingContext = model = new NovostiViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajNovosti();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var novost = e.SelectedItem as Model.Novosti;
            await Navigation.PushAsync(new DetaljiNovostiPage(novost));
        }
    }
}