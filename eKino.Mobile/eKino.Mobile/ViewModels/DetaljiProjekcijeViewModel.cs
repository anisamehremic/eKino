using eKino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class DetaljiProjekcijeViewModel:BaseViewModel
    {
        Model.Projekcije p = null;
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _filmoviFilmskeLicnosti = new APIService("FilmoviFilmskeLicnosti");
        private readonly APIService _drzave = new APIService("Drzave");
        public DetaljiProjekcijeViewModel()
        {
        }
        public DetaljiProjekcijeViewModel(Model.Projekcije projekcija)
        {
            p = projekcija;
        }

        public ICommand RezervisiCommand { get; set; }
        public async Task UcitajDetaljeProjekcije()
        {
            var projekcija = await _projekcije.GetById<Model.Projekcije>(p.ProjekcijaId);
            ProjekcijaId = projekcija.ProjekcijaId;
            Film = projekcija.Film.ToString();
            OpisFilma = projekcija.Film.Opis;
            var drzava = await _drzave.GetById<Model.Drzave>(projekcija.Film.DrzavaId);
            Drzava = drzava.Naziv;
            Sala = projekcija.Sala.Naziv;
            VrstaProjekcije = projekcija.VrstaProjekcije.Naziv;
            Slika = projekcija.Film.Slika;
            var filmskeLicnosti =await _filmoviFilmskeLicnosti.Get<List<Model.FilmoviFilmskeLicnosti>>(null);
            string glumci = "";
            foreach(var item in filmskeLicnosti)
            {
                if (item.FilmId == projekcija.FilmId && item.FilmskaUloga.Naziv=="Glumac")
                {
                    glumci += item.FilmskaLicnost.Ime + " " + item.FilmskaLicnost.Prezime + ", ";
                }
            }
            string reziseri = "";
            foreach (var item in filmskeLicnosti)
            {
                if (item.FilmId == projekcija.FilmId && item.FilmskaUloga.Naziv == "Režiser")
                {
                    reziseri += item.FilmskaLicnost.Ime + " " + item.FilmskaLicnost.Prezime + ", ";
                }
            }
            Glumci = glumci;
            Reziser = reziseri;
        }


        int _projekcijaId=0;
        public int ProjekcijaId
        {
            get { return _projekcijaId; }
            set { SetProperty(ref _projekcijaId, value); }
        }


        string _film = null;
        public string Film
        {
            get { return _film; }
            set {SetProperty(ref _film, value);}
        }

        string _opisFilma = null;
        public string OpisFilma
        {
            get { return _opisFilma; }
            set { SetProperty(ref _opisFilma, value); }
        }

        string _sala = null;
        public string Sala
        {
            get { return _sala; }
            set { SetProperty(ref _sala, value); }
        }

        string _vrstaProjekcije = null;
        public string VrstaProjekcije
        {
            get { return _vrstaProjekcije; }
            set { SetProperty(ref _vrstaProjekcije, value); }
        }

        string _drzava = null;
        public string Drzava
        {
            get { return _drzava; }
            set { SetProperty(ref _drzava, value); }
        }

        string _glumci = null;
        public string Glumci
        {
            get { return _glumci; }
            set { SetProperty(ref _glumci, value); }
        }

        string _reziser = null;
        public string Reziser
        {
            get { return _reziser; }
            set { SetProperty(ref _reziser, value); }
        }

        byte[] _slika ;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
    }
}
