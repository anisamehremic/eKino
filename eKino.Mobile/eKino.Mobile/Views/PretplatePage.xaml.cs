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
    public partial class PretplatePage : ContentPage
    {
        PretplateViewModel model = null;
        public PretplatePage()
        {
            InitializeComponent();
            BindingContext = model = new PretplateViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajPretplate();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int? PretplataId = ((Button)sender).BindingContext as int?;
            await model.OtkaziPretplatu(PretplataId);
        }
    }
}