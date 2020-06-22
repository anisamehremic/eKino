using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Mobile.ViewModels
{
    public class UlazniceViewModel
    {
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        public UlazniceViewModel()
        {

        }
        public ObservableCollection<Model.Ulaznice> UlazniceList { get; set; } = new ObservableCollection<Model.Ulaznice>();

        public async Task UcitajUlaznice()
        {
            GledaociSearchRequest request = new GledaociSearchRequest()
            {
                Username = APIService.Username
            };
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(request);
            var gledalac = gledaoci[0].GledalacId;

            UlazniceSearchRequest request1 = new UlazniceSearchRequest() { 
                GledalacId=gledalac
            };
            var ulaznice = await _ulaznice.Get<List<Model.Ulaznice>>(request1);
            UlazniceList.Clear();
            foreach(var item in ulaznice)
            {
                UlazniceList.Add(item);
            }

        }
    }
}
