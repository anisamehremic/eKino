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
    public partial class ZanroviPage : ContentPage
    {
        ZanroviViewModel model = null;
        public ZanroviPage()
        {
            InitializeComponent();
            BindingContext = model = new ZanroviViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajZanrove();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int? zanrId = ((Button)sender).BindingContext as int?;
            await model.PretplatiSe(zanrId);
        }
    }
}