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
    public partial class DetaljiNovostiPage : ContentPage
    {
        DetaljiNovostiViewModel model = null;
        public DetaljiNovostiPage(Model.Novosti novost)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiNovostiViewModel(novost);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajDetalje();
        }
    }
}