using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Rezervacije
{
    public partial class frmDodajUrediRezervaciju : Form
    {
        private int? Id = null;
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        private readonly APIService _sjedista = new APIService("Sjedista");
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        public frmDodajUrediRezervaciju(int? rezervacijaId = null)
        {
            InitializeComponent();
            Id = rezervacijaId;
        }

        private void cmbProjekcije_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbProjekcije, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }


        private async void frmDodajUrediRezervaciju_Load(object sender, EventArgs e)
        {
            var projekcije = await _projekcije.Get<List<Model.Projekcije>>(null);
            var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(null);

            foreach (var item in projekcije)
            {
                item.FilmSala = item.Film.Naziv + "|" + item.Sala.Naziv;
            }
            projekcije.Insert(0, new Model.Projekcije() { });
            gledaoci.Insert(0, new Model.Gledaoci() { });


            cmbProjekcije.DataSource = projekcije;
            cmbProjekcije.DisplayMember = "FilmSala";
            cmbProjekcije.ValueMember = "ProjekcijaId";

            cmbGledaoci.DataSource = gledaoci;
            cmbGledaoci.DisplayMember = "Ispis";
            cmbGledaoci.ValueMember = "GledalacId";

            if (Id != null)
            {
                var rezervacija = await _rezervacije.GetById<Model.Rezervacije>(Id);
                cmbProjekcije.SelectedValue = rezervacija.ProjekcijaId;
                if (rezervacija.GledalacId.HasValue) { 
                    cmbGledaoci.SelectedValue = rezervacija.GledalacId;
                }
             
            }

        }

        private async void cmbProjekcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProjekcije.SelectedIndex > 0)
            {
                var projekcija = await _projekcije.GetById<Model.Projekcije>(cmbProjekcije.SelectedValue);
                MemoryStream stream = new MemoryStream(projekcija.Sala.Slika);
                pictureBox.Image = Image.FromStream(stream);
                
                SjedistaSearchRequest request = new SjedistaSearchRequest() {
                    SalaId = projekcija.SalaId
                };
                var sjedista = await _sjedista.Get<List<Model.Sjedista>>(request);

                UlazniceSearchRequest search = new UlazniceSearchRequest() {
                    ProjekcijaId = int.Parse(cmbProjekcije.SelectedValue.ToString()),
                    RezervacijaId=Id
                };
                var sveUlaznice = await _ulaznice.Get<List<Model.Ulaznice>>(null);
                var novaSjedista = new List<Model.Sjedista>();
                var mojaSjedista = new List<Model.Sjedista>();

                foreach(var item in sjedista)
                {
                    bool ima = true;
                    foreach(var item2 in sveUlaznice)
                    {
                        if(item.SjedisteId == item2.SjedisteId && item2.Status == true && item2.RezervacijaId == Id)
                        {
                            mojaSjedista.Add(item);
                        }
                        if(item.SjedisteId==item2.SjedisteId && item2.Status && item2.RezervacijaId != Id)
                        {
                            ima = false;
                        }
                    }
                    if (ima)
                    {
                        novaSjedista.Add(item);
                    }
                }

                clbSjedista.DataSource = novaSjedista;
                clbSjedista.DisplayMember = "Ispis";
                clbSjedista.ValueMember = "SjedisteId";

                for(int i=0; i<clbSjedista.Items.Count; i++)
                {
                    foreach(var item2 in mojaSjedista)
                    {
                        var s = (Model.Sjedista)clbSjedista.Items[i];
                        if (s.SjedisteId == item2.SjedisteId)
                        {
                            clbSjedista.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
            }
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (clbSjedista.CheckedItems.Count > 0)
            {
                var rezervacija = await _rezervacije.GetById<Model.Rezervacije>(Id);
                var sjedista = clbSjedista.CheckedItems.Cast<Model.Sjedista>();
                var projekcija = await _projekcije.GetById<Model.Projekcije>(cmbProjekcije.SelectedValue);
               
                var brojSjedista = sjedista.Count();
                RezervacijeUpsertRequest rezervacijaUpsert = new RezervacijeUpsertRequest()
                {
                    ProjekcijaId = projekcija.ProjekcijaId,
                    BrojKarata = brojSjedista,
                    Cijena = brojSjedista * projekcija.Cijena,
                    DatumRezervacije = DateTime.Now,
                    Status = chbAktivna.Checked
                };

                if (cmbGledaoci.SelectedValue != null) {
                    rezervacijaUpsert.GledalacId = (int)cmbGledaoci.SelectedValue;
                }

                rezervacijaUpsert.requestsUlaznice = new List<UlazniceUpsertRequest>();
                foreach (var item in sjedista)
                {
                    UlazniceUpsertRequest request = new UlazniceUpsertRequest()
                    {
                        RezervacijaId = Id,
                        ProjekcijaId = int.Parse(cmbProjekcije.SelectedValue.ToString()),
                        SjedisteId = item.SjedisteId,
                        Cijena = projekcija.Cijena,
                        QRtekst =$"Gledalac: {rezervacija.Gledalac?.Ime ?? "-Default-"} {rezervacija.Gledalac?.Prezime ?? "-Default-"} " +
                        $"{rezervacija.Gledalac?.KorisnickoIme ?? "-Default-"} \n Projekcija: {rezervacija.Projekcija} \n",
                        Status = rezervacijaUpsert.Status// ako je rezervacija aktivna da bude i ulaznica i obrnuto
                    };
                    if (cmbGledaoci.SelectedIndex != 0)
                    {
                        var objGledalac = cmbGledaoci.SelectedValue;
                        rezervacijaUpsert.GledalacId = int.Parse(objGledalac?.ToString() ?? "0");
                    }

                    rezervacijaUpsert.requestsUlaznice.Add(request);
                }

                Model.Rezervacije result = null;
                if (Id.HasValue)
                {
                    result = await _rezervacije.Update<Model.Rezervacije>(Id, rezervacijaUpsert);
                }
                else { 
                    result = await _rezervacije.Insert<Model.Rezervacije>(rezervacijaUpsert);
                }

                if (result != null)
                {
                    MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali nijedno sjedište.");
            }
        }

        private async void clbSjedista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProjekcije.SelectedValue!=null ) {
            var projekcija = await _projekcije.GetById<Model.Projekcije>(cmbProjekcije.SelectedValue);
            txtCijena.Text = (clbSjedista.CheckedItems.Count*projekcija.Cijena).ToString()+" KM";
            }
        }
    }
}
