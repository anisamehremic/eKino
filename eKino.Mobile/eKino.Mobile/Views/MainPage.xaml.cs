using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eKino.Mobile.Models;

namespace eKino.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijePage()));
                        break;
                    case (int)MenuItemType.MojiPodaci:
                        MenuPages.Add(id, new NavigationPage(new MojiPodaciPage()));
                        break;
                    case (int)MenuItemType.Novosti:
                        MenuPages.Add(id, new NavigationPage(new NovostiPage()));
                        break;
                    case (int)MenuItemType.Zanrovi:
                        MenuPages.Add(id, new NavigationPage(new ZanroviPage()));
                        break;
                    case (int)MenuItemType.Pretplate:
                        MenuPages.Add(id, new NavigationPage(new PretplatePage()));
                        break;
                    case (int)MenuItemType.Projekcije:
                        MenuPages.Add(id, new NavigationPage(new ProjekcijePage()));
                        break;
                    case (int)MenuItemType.Ulaznice:
                        MenuPages.Add(id, new NavigationPage(new UlaznicePage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new ObavijestiPage()));
                        break;
                    case (int)MenuItemType.OdjaviSe:
                        MenuPages.Add(id, new NavigationPage(new OdjaviSePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}