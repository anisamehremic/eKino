using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class ProjekcijeViewModel:BaseViewModel
    {
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _preporuke = new APIService("Preporuke");
        private readonly APIService _filmoviFilmskeLicnosti = new APIService("FilmoviFilmskeLicnosti");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _filmoviZanrovi = new APIService("FilmoviZanrovi");
        private readonly APIService _ocjene = new APIService("Ocjene");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        public ProjekcijeViewModel()
        {
            UcitajProjekcijeCommand = new Command(async()=>await UcitajProjekcije());
        }
        public ObservableCollection<Model.Projekcije> ProjekcijeList { get; set; } = new ObservableCollection<Model.Projekcije>();
        public ObservableCollection<Model.Projekcije> PreporuceneProjekcijeList { get; set; } = new ObservableCollection<Model.Projekcije>();
        public ObservableCollection<Model.Zanrovi> ZanroviList { get; set; } = new ObservableCollection<Model.Zanrovi>();
        public ObservableCollection<int> OcjeneList { get; set; } = new ObservableCollection<int>() {0, 1, 2, 3, 4, 5};
        public ICommand UcitajProjekcijeCommand { get; set; }

        public async Task UcitajProjekcije()
        {
            if (ZanroviList.Count == 0)
            {
                var zanrovi = await _zanrovi.Get<List<Model.Zanrovi>>(null);
                foreach (var item in zanrovi)
                {
                        ZanroviList.Add(item);
                }
            }

            
            var projekcije = await _projekcije.Get<List<Model.Projekcije>>(null);
            var filmoviZanrovi = await _filmoviZanrovi.Get<List<Model.FilmoviZanrovi>>(null);
            ProjekcijeList.Clear();
            
            foreach (var item in projekcije)
            {
                if (item.DatumVrijemeOdrzavanja > DateTime.Now)
                {
                    if (SelectedOcjena == 0 && SelectedZanr == null)
                    {
                        var drzava = await _drzave.GetById<Model.Drzave>(item.Film.DrzavaId);
                        item.Drzava = drzava.Naziv;
                        bool ima = false;
                        foreach (var p in ProjekcijeList)
                        {
                            if (item.ProjekcijaId == p.ProjekcijaId)
                                ima = true;
                        }
                        if (!ima)
                            ProjekcijeList.Add(item);
                    }

                    else if (SelectedZanr != null && SelectedOcjena==0)
                    {
                        foreach (var item2 in filmoviZanrovi)
                        {
                            if (item2.FilmId==item.FilmId && SelectedZanr.ZanrId==item2.ZanrId) {
                                var drzava = await _drzave.GetById<Model.Drzave>(item.Film.DrzavaId);
                                item.Drzava = drzava.Naziv;

                                ProjekcijeList.Add(item);
                            }
                        }
                    }
                    else if (SelectedOcjena != 0 && SelectedZanr==null)
                    {
                        OcjeneSearchRequest request = new OcjeneSearchRequest()
                        {
                            FilmId=item.FilmId
                        };
                        var ocjene =await _ocjene.Get<List<Model.Ocjene>>(request);
                        int suma = 0;
                        int prosjek = 0;
                        foreach(var item2 in ocjene)
                        {
                            if (item2.FilmId == item.FilmId)
                            {
                                suma += item2.Ocjena;
                            }
                        }
                        if (suma == 0)
                        {
                            if (ProjekcijeList.Contains(item))
                                ProjekcijeList.Remove(item);
                        }
                        else
                        {
                            prosjek = suma / ocjene.Count;
                            if (prosjek >= SelectedOcjena)
                            {
                                ProjekcijeList.Add(item);
                            }

                        }
                    }


                    else if(SelectedOcjena!=0 && SelectedZanr!=null)
                    {
                        foreach (var item2 in filmoviZanrovi)
                        {
                            if (item2.FilmId == item.FilmId && SelectedZanr.ZanrId == item2.ZanrId)
                            {
                                var drzava = await _drzave.GetById<Model.Drzave>(item.Film.DrzavaId);
                                item.Drzava = drzava.Naziv;
                                ProjekcijeList.Add(item);
                            }
                        }

                        OcjeneSearchRequest request = new OcjeneSearchRequest()
                        {
                            FilmId = item.FilmId
                        };
                        var ocjene = await _ocjene.Get<List<Model.Ocjene>>(request);
                        int suma = 0;
                        int prosjek = 0;
                        int brojac = 0;
                        foreach (var item2 in ocjene)
                        {
                            if (item2.FilmId == item.FilmId)
                            {
                                suma += item2.Ocjena;
                                brojac++;
                            }
                        }
                        if (suma==0)
                        {
                            if (ProjekcijeList.Contains(item))
                                ProjekcijeList.Remove(item);
                        }
                        else
                        {
                            prosjek = suma / ocjene.Count;
                            if (prosjek >= SelectedOcjena)
                            {
                                if (!ProjekcijeList.Contains(item))
                                    ProjekcijeList.Add(item);
                            }

                        }
                    }
                }
               
            }
        }

        public async Task UcitajPreporuceneProjekcije()
        {
            PreporuceneProjekcijeList.Clear();
            GledaociSearchRequest requestGledalac = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(requestGledalac);
            var gledalac = listaGledaoci[0].GledalacId;
            var preporuke = await _preporuke.Get<List<Model.Projekcije>>(gledalac);
            var rezervacije = await _rezervacije.Get<List<Model.Rezervacije>>(gledalac);
            foreach (var item in preporuke)
            {
                bool ima = false;
                foreach(var item2 in rezervacije)
                {
                    if (item.ProjekcijaId == item2.ProjekcijaId)
                        ima = true;
                }
                if(!ima)
                PreporuceneProjekcijeList.Add(item);
            }
        }

        Zanrovi _selectedZanr=null;
        public Zanrovi SelectedZanr
        {
            get { return _selectedZanr; }
            set { SetProperty(ref _selectedZanr, value);
                if (value != null)
                {
                    UcitajProjekcijeCommand.Execute(null);
                }
            }
        }

        DateTime _datumVrijeme;
        public DateTime DatumVrijemeOdrzavanja
        {
            get { return _datumVrijeme; }
            set { SetProperty(ref _datumVrijeme, value); }
        }

        int _selectedOcjena = 0;
        public int SelectedOcjena
        {
            get { return _selectedOcjena; }
            set
            {
                SetProperty(ref _selectedOcjena, value);
                if (value != null)
                {
                    UcitajProjekcijeCommand.Execute(null);
                }
            }
        }

    }
}
