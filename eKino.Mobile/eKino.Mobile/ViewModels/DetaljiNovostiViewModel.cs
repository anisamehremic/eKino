using eKino.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.Views
{
    public class DetaljiNovostiViewModel: BaseViewModel
    {
        Model.Novosti n = null;
        private readonly APIService _novosti = new APIService("Novosti");

        public DetaljiNovostiViewModel()
        {

        }
        public DetaljiNovostiViewModel(Model.Novosti novost=null)
        {
            n = novost;
            UcitajDetaljeCommand = new Command(async()=>await UcitajDetalje());
        }
        public ICommand UcitajDetaljeCommand { get; set; }
        public async Task UcitajDetalje()
        {
            var novost = await _novosti.GetById<Model.Novosti>(n.NovostId);
            Naslov = novost.Naslov;
            Sadrzaj = novost.Sadrzaj;
        }

        string _naslov = string.Empty;
        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }

        string _sadrzaj = string.Empty;
        public string Sadrzaj
        {
            get { return _sadrzaj; }
            set { SetProperty(ref _sadrzaj, value); }
        }
    }
}
