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
    public class RezervacijeViewModel:BaseViewModel
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        public RezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Model.Rezervacije>();
        public ICommand InitCommand {get; set; }

        public async Task Init()
        {
            RezervacijeSearchRequest request = new RezervacijeSearchRequest() {
                Username = APIService.Username
            };
            var list = await _rezervacije.Get<IEnumerable<Model.Rezervacije>>(request);
            RezervacijeList.Clear(); 
            foreach(var item in list)
            {
                if(item.Status==true)
                RezervacijeList.Add(item);
            }                  
        }
    }
}
