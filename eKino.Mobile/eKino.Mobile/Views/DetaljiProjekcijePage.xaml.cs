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
    public partial class DetaljiProjekcijePage : ContentPage
    {
        DetaljiProjekcijeViewModel model = null;
        public DetaljiProjekcijePage(Model.Projekcije projekcija)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiProjekcijeViewModel(projekcija);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajDetaljeProjekcije();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int? projekcijaId = ((Button)sender).BindingContext as int?;
            Navigation.PushAsync(new SjedistaPage(new Model.Rezervacije() { ProjekcijaId=projekcijaId.Value}));
        }
    }
}