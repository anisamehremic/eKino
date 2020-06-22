using eKino.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.MojiPodaci, Title="Moji podaci" },
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Rezervacije" },
                new HomeMenuItem {Id = MenuItemType.Novosti, Title="Novosti" },
                new HomeMenuItem {Id = MenuItemType.Zanrovi, Title="Žanrovi" },
                new HomeMenuItem {Id = MenuItemType.Pretplate, Title="Pretplate" },
                new HomeMenuItem {Id = MenuItemType.Projekcije, Title="Projekcije" },
                new HomeMenuItem {Id = MenuItemType.Ulaznice, Title="Ulaznice" },
                new HomeMenuItem {Id = MenuItemType.Obavijesti, Title="Obavijesti" },
                new HomeMenuItem {Id = MenuItemType.OdjaviSe, Title="Odjavi se" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);

            };
        }
    }
}