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
    public partial class DetaljiUlaznicePage : ContentPage
    {
        DetaljiUlazniceViewModel model = null;
        public DetaljiUlaznicePage(Model.Ulaznice ulaznica)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiUlazniceViewModel(ulaznica);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajDetalje();
        }
    }
}