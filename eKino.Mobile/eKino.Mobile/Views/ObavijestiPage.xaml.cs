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
    public partial class ObavijestiPage : ContentPage
    {
        ObavijestiViewModel model = null;
        public ObavijestiPage()
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiViewModel();
        }

        protected override void OnAppearing()
        {
            model.UcitajProcitaneCommand.Execute(null);
            model.UcitajNeprocitaneCommand.Execute(null);
        }
    }
}