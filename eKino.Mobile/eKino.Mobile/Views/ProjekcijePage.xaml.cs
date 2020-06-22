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
    public partial class ProjekcijePage : ContentPage
    {
        ProjekcijeViewModel model = null;
        public ProjekcijePage()
        {
            InitializeComponent();
            BindingContext = model = new ProjekcijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajProjekcije();
            await model.UcitajPreporuceneProjekcije();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var projekcija = e.SelectedItem as Model.Projekcije;
            await Navigation.PushAsync(new DetaljiProjekcijePage(projekcija));
        }

    }
}