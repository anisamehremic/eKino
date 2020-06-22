using eKino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Mobile.ViewModels
{
    public class DetaljiUlazniceViewModel:BaseViewModel
    {
        Model.Ulaznice u = null; 
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        public DetaljiUlazniceViewModel(Model.Ulaznice ulaznica)
        {
            u = ulaznica;
        }

        public async Task UcitajDetalje()
        {
            var ulaznica = await _ulaznice.GetById<Model.Ulaznice>(u.UlaznicaId);
            Sala = ulaznica.Projekcija.Sala.Naziv;
            Red = ulaznica.Sjediste.Red;
            Sjediste = ulaznica.Sjediste.Kolona;
            Cijena = ulaznica.Cijena;
            Slika = ulaznica.Qrcode;
            VrstaProjekcije = ulaznica.Projekcija.VrstaProjekcije.Naziv;
            Projekcija = ulaznica.Projekcija;
        }

        Projekcije _projekcija ;
        public Projekcije Projekcija
        {
            get { return _projekcija; }
            set { SetProperty(ref _projekcija, value); }
        }

        string _sala = string.Empty;
        public string Sala
        {
            get { return _sala; }
            set { SetProperty(ref _sala, value); }
        }
        string _red = string.Empty;
        public string Red
        {
            get { return _red; }
            set { SetProperty(ref _red, value); }
        }
        
        string _sjediste = string.Empty;
        public string Sjediste
        {
            get { return _sjediste; }
            set { SetProperty(ref _sjediste, value); }
        }
        
        decimal _cijena;
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
        
        byte[] _slika;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
        
        string _vrstaProjekcije=string.Empty;
        public string VrstaProjekcije
        {
            get { return _vrstaProjekcije; }
            set { SetProperty(ref _vrstaProjekcije, value); }
        }
    }
}
