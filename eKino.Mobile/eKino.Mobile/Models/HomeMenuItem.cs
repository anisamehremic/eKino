using System;
using System.Collections.Generic;
using System.Text;

namespace eKino.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Rezervacije,
        MojiPodaci,
        Novosti,
        Zanrovi,
        Pretplate,
        Projekcije,
        Ulaznice,
        Obavijesti,
        OdjaviSe
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
