using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKino.Mobile.Services;
using eKino.Mobile.Views;

namespace eKino.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
