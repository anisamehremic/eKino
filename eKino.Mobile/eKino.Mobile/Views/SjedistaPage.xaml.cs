using eKino.Mobile.ViewModels;
using eKino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SjedistaPage : ContentPage
    {
        readonly SjedistaViewModel model = null;
        private readonly Rezervacije rezervacija;
        private Sjedista odabranoSjedaloObj = null;

        public SjedistaPage(Rezervacije rezervacija)
        {
            InitializeComponent();
            BindingContext = model = new SjedistaViewModel(rezervacija) { };
            this.rezervacija = rezervacija;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            var brSjedala = model.BrojSjedista;
            this.Sjedista.Children.Clear();
            this.Sjedista.RowDefinitions = new RowDefinitionCollection();
            this.Sjedista.ColumnDefinitions = new ColumnDefinitionCollection();
            var brR = 0;
            this.Sjedista.RowDefinitions.Add(new RowDefinition());

            var brK = 0;
            for (int i = 0; i < brSjedala; i++)
            {
                if (i % 6 == 0 && i != 0)
                {
                    brR++;
                    this.Sjedista.RowDefinitions.Add(new RowDefinition { Height = 30 });
                    brK = 0;
                }
                this.Sjedista.ColumnDefinitions.Add(new ColumnDefinition { Width = 47 });
                Button l = new Button
                {
                    MinimumWidthRequest = 40,
                    Text = model.SjedistaList[i].Red.ToString()+ model.SjedistaList[i].Kolona.ToString(),
                    TextColor = Color.White,
                    CornerRadius = 10,

                    HeightRequest = 30,
                    WidthRequest = 47,
                    FontSize = 10,

                    BindingContext = model.SjedistaList[i]
                };

                bool zauzeto = false;
                foreach (Ulaznice ulaznica in model.UlazniceList)
                {
                    if (rezervacija.ProjekcijaId == ulaznica.ProjekcijaId && model.SjedistaList[i].SjedisteId == ulaznica.SjedisteId && ulaznica.Status)
                    {
                        zauzeto = true;
                        break;
                    }
                }

                if (zauzeto)
                {
                    l.BackgroundColor = Color.FromHex("#ed112e");
                }
                else
                {
                    l.BackgroundColor =Color.FromHex("#27d956");
                    l.Pressed += btn_Clicked;
                }

                this.Sjedista.Children.Add(l, brK, brR);
                brK++;

            }

        }


        private void btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            for (int i = 0; i < this.Sjedista.ColumnDefinitions.Count; i++)
            {
                var btn2 = this.Sjedista.Children[i] as Button;
                if (btn2.Text != btn.Text && btn2.IsEnabled == false)
                {
                    btn2.IsEnabled = true;
                    btn2.BackgroundColor = Color.FromHex("#27d956");
                }

            }

            btn.BackgroundColor = Color.Gray;
            btn.IsEnabled = false;
            this.Dalje.IsVisible = true;
            this.Odabrano.Text = btn.Text;
            this.odabranoSjedaloObj = btn.BindingContext as Sjedista;
            this.Poruka.Text = "Odabrali ste sjedište " + btn.Text;
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ProjekcijePage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Model.Sjedista sjediste = ((Button)sender).BindingContext as Model.Sjedista;
            model.NapraviRezervaciju(odabranoSjedaloObj.Red+odabranoSjedaloObj.Kolona, rezervacija.ProjekcijaId);
            //Application.Current.MainPage = new NavigationPage(new UlaznicePage(this.rezervacija, this.odabranoSjedaloObj));
        }
    }
}
