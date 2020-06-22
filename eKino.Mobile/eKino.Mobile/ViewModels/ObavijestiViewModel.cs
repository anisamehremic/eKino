using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class ObavijestiViewModel : BaseViewModel
    {
        private readonly APIService _notifikacije = new APIService("Notifikacije");
        private readonly APIService _gledaoci = new APIService("Gledaoci");

        private Model.Notifikacije _selectedNotifikacija = null;
        public Model.Notifikacije SelectedNotifikacija {
            get { return _selectedNotifikacija; }
            set { SetProperty(ref _selectedNotifikacija, value);
                if (value != null) {
                    ProcitajObavijestCommand.Execute(null);
                }
            }
        }
        public ObavijestiViewModel()
        {
            UcitajProcitaneCommand = new Command(async () => await UcitajProcitane());
            UcitajNeprocitaneCommand = new Command(async () => await UcitajNeprocitane());
            ProcitajObavijestCommand = new Command(async () => await ProcitajObavijest());
        }

        public ICommand UcitajProcitaneCommand { get; set; }
        public ICommand UcitajNeprocitaneCommand { get; set; }
        public ICommand ProcitajObavijestCommand { get; set; }

        public ObservableCollection<Model.Notifikacije> ProcitaneNotifikacijeList { get; set; } = new ObservableCollection<Model.Notifikacije>();
        public ObservableCollection<Model.Notifikacije> NeprocitaneNotifikacijeList { get; set; } = new ObservableCollection<Model.Notifikacije>();

        public async Task ProcitajObavijest() {
            if (SelectedNotifikacija != null)
            {
                NotifikacijeUpsertRequest request = new NotifikacijeUpsertRequest()
                {
                    DatumSlanja = SelectedNotifikacija.DatumSlanja,
                    GledalacId = SelectedNotifikacija.GledalacId,
                    Naslov = SelectedNotifikacija.Naslov,
                    NovostId = SelectedNotifikacija.NovostId,
                    Procitana = true
                };

                var entity = await _notifikacije.Update<Model.Notifikacije>(SelectedNotifikacija.NotifikacijaId, request);
                if (entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavijest", "Obavijest pročitana!", "OK");
                    await UcitajNeprocitane();
                    await UcitajProcitane();
                }
            }
        }
        public async Task UcitajProcitane()
        {
            GledaociSearchRequest requestGledaoci = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(requestGledaoci);
            var gledalac = listaGledaoci[0].GledalacId;

            NotifikacijeSearchRequest request = new NotifikacijeSearchRequest() { Procitana = true, GledalacId=gledalac };
            var procitane = await _notifikacije.Get<List<Model.Notifikacije>>(request);
            ProcitaneNotifikacijeList.Clear();
            foreach(var item in procitane)
            {
                ProcitaneNotifikacijeList.Add(item);
            }
            if(ProcitaneNotifikacijeList.Count>0)
                ProcitaneNotifikacijeList.OrderByDescending(a => a.DatumSlanja);

        }
        public async Task UcitajNeprocitane()
        {
            GledaociSearchRequest requestGledaoci = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(requestGledaoci);
            var gledalac = listaGledaoci[0].GledalacId;

            NotifikacijeSearchRequest request = new NotifikacijeSearchRequest() { Neprocitana = true, GledalacId = gledalac };
            var neprocitane = await _notifikacije.Get<List<Model.Notifikacije>>(request);
            NeprocitaneNotifikacijeList.Clear();
            foreach (var item in neprocitane)
            {
                NeprocitaneNotifikacijeList.Add(item);
            }
            if( NeprocitaneNotifikacijeList.Count >0)
                NeprocitaneNotifikacijeList.OrderByDescending(a => a.DatumSlanja);
        }
    }
}
