using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class PretplateViewModel:BaseViewModel
    {
        private readonly APIService _pretplate = new APIService("Pretplate");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        public PretplateViewModel()
        {
            UcitajPretplateCommand = new Command(async()=>await UcitajPretplate());
        }
        public ICommand UcitajPretplateCommand { get; set; } 
        public ICommand OtkaziPretplatuCommand { get; set; }
        public ObservableCollection<Model.Pretplate> PretplateList { get; set; } = new ObservableCollection<Model.Pretplate>();

        public async Task UcitajPretplate()
        {
            GledaociSearchRequest request = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request);
            var gledalac = listaGledaoci[0].GledalacId;
            var pretplate = await _pretplate.Get<List<Model.Pretplate>>(null);
            var lista = new List<Model.Pretplate>();
            foreach(var item in pretplate)
            {
                if (item.GledalacId == gledalac && !item.Otkazana)
                    lista.Add(item);
            }

            PretplateList.Clear();
            foreach(var item in lista)
            {
                PretplateList.Add(item);
            }
        }
        public async Task OtkaziPretplatu(int?PretplataId)
        {
            var p = int.Parse(PretplataId.ToString());
                var pretplata = await _pretplate.GetById<Model.Pretplate>(p);
                PretplateUpsertRequest request2 = new PretplateUpsertRequest()
                {
                    DatumPretplate = DateTime.Now,
                    GledalacId = pretplata.GledalacId,
                    Otkazana = true,
                    ZanrId = pretplata.ZanrId,
                };
                await _pretplate.Update<Model.Pretplate>(pretplata.PretplataId, request2);
                await Application.Current.MainPage.DisplayAlert("Otkazivanje pretplate", "Uspješno otkazana pretplata", "OK");
                await UcitajPretplate();
        }

        int _pretplataId = 0;
        public int PretplataId
        {
            get { return _pretplataId; }
            set { SetProperty(ref _pretplataId, value);

            }
        }
    }
}