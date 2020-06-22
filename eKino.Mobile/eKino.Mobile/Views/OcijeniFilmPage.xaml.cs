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
    public partial class OcijeniFilmPage : ContentPage
    {
        Model.Rezervacije r = null;
        OcijeniFilmViewModel model = null;
        public OcijeniFilmPage(Model.Rezervacije rezervacija)
        {
            InitializeComponent();
            r = rezervacija;
            BindingContext = model = new OcijeniFilmViewModel(rezervacija);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string ocjena = ((Button)sender).BindingContext as string;
            await model.OcijeniFilm(ocjena);
        }
    }
}