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
    public class NovostiViewModel
    {
        private readonly APIService _novosti = new APIService("Novosti");
        public NovostiViewModel()
        {
            UcitajNovostiCommand = new Command(async()=>await UcitajNovosti()); 
        }
        public ObservableCollection<Model.Novosti> NovostiList { get; set; } = new ObservableCollection<Model.Novosti>();
        public ICommand UcitajNovostiCommand { get; set; }
        public async Task UcitajNovosti()
        {
            var novosti = await _novosti.Get<IEnumerable<Model.Novosti>>(null);
            NovostiList.Clear();
            foreach (var item in novosti)
            {
                NovostiList.Add(item);
            }
            NovostiList.OrderBy(a => a.DatumObjave);
        }

    }
}
