using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Novosti
{
    public partial class frmDodajUrediNovosti : Form
    {
        private int? Id = null;
        private readonly APIService _novosti = new APIService("Novosti");
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _notifikacije = new APIService("Notifikacije");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        public frmDodajUrediNovosti(int? novostId=null)
        {
            InitializeComponent();
            Id = novostId;
        }

        private async void frmDodajUrediNovosti_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                var novost =await _novosti.GetById<Model.Novosti>(Id);
                txtNaslov.Text = novost.Naslov;
                txtSadrzaj.Text = novost.Sadrzaj;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var korisnici = await _korisnici.Get<List<Model.Korisnici>>(null);
                var listaKorisnika = korisnici.ToList();
                NovostiUpsertRequest request = new NovostiUpsertRequest()
                {
                    Naslov = txtNaslov.Text,
                    Sadrzaj = txtSadrzaj.Text,
                    DatumObjave = DateTime.Now,
                    KorisnikId = listaKorisnika.Where(a => a.KorisnickoIme == APIService.Username).FirstOrDefault().KorisnikId
                };
                if (Id != null)
                {
                    var result = await _novosti.Update<Model.Novosti>(Id, request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
                else
                {
                    var result = await _novosti.Insert<Model.Novosti>(request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                        var gledaoci = await _gledaoci.Get<List<Model.Gledaoci>>(null);
                        foreach (var item in gledaoci)
                        {
                            NotifikacijeUpsertRequest request2 = new NotifikacijeUpsertRequest()
                            {
                                DatumSlanja = DateTime.Now,
                                NovostId = result.NovostId,
                                Naslov = request.Naslov,
                                Procitana = false,
                                GledalacId = item.GledalacId
                            };
                            await _notifikacije.Insert<Model.Notifikacije>(request2);
                        }
                    }
                }
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNaslov, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeRtxt(txtSadrzaj, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
