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
    public class ZanroviViewModel:BaseViewModel
    {
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _gledalac = new APIService("Gledaoci");
        private readonly APIService _pretplate = new APIService("Pretplate");
        public ZanroviViewModel()
        {
            UcitajZanroveCommand = new Command(async()=>await UcitajZanrove());
        }
        public ObservableCollection<Model.Zanrovi> ZanroviList { get; set; } = new ObservableCollection<Model.Zanrovi>();
        public ICommand UcitajZanroveCommand { get; set; }
        public async Task UcitajZanrove()
        {
            GledaociSearchRequest request = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var listaGledaoci = await _gledalac.Get<List<Model.Gledaoci>>(request);
            var gledalac = listaGledaoci[0].GledalacId;

            var pretplate = await _pretplate.Get<List<Model.Pretplate>>(null);
            var zanrovi = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            var novaLista = new List<Model.Zanrovi>();
            var novaLista2 = new List<Model.Zanrovi>();

            foreach (var item in zanrovi)
            {
                bool ima = false;
                foreach (var item2 in pretplate)
                {

                    if (item.ZanrId == item2.ZanrId && gledalac == item2.GledalacId && !item2.Otkazana)
                        ima = true;
                }
                if (ima)
                    novaLista.Add(item);
            }

            foreach(var item in zanrovi)
            {
                if (!novaLista.Contains(item))
                    novaLista2.Add(item);
            }

            ZanroviList.Clear();
            foreach (var item in novaLista2)
            {
                ZanroviList.Add(item);
            }
        }

        public async Task PretplatiSe(int? ZanrId)
        {
            int z = int.Parse(ZanrId.ToString());
            GledaociSearchRequest request = new GledaociSearchRequest() { 
                Username=APIService.Username
            };
            var listaGledaoci =await _gledalac.Get<List<Model.Gledaoci>>(request);
            PretplateUpsertRequest request2 = new PretplateUpsertRequest()
            {
                ZanrId = z,
                DatumPretplate = DateTime.Now,
                GledalacId=listaGledaoci[0].GledalacId,
                Otkazana=false
            };
            await _pretplate.Insert<Model.Pretplate>(request2);
            await Application.Current.MainPage.DisplayAlert("Pretplata na žanr", "Uspješno ste se pretplatili na željeni žanr.", "OK");
            await UcitajZanrove();
        }
        string _naziv = string.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
        
        int _zanrId=0;
        public int ZanrId
        {
            get { return _zanrId; }
            set { SetProperty(ref _zanrId, value);}
        }

    }
}
