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

namespace eKino.WinUI.Korisnici
{
    public partial class frmPrikazKorisnika : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _korisnickeUloge = new APIService("KorisnickeUloge");
        private readonly APIService _uloge = new APIService("Uloge");
        public frmPrikazKorisnika()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void frmPrikazKorisnika_Load(object sender, EventArgs e)
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            var result2 = await _korisnickeUloge.Get<List<Model.KorisnickeUloge>>(null);
            foreach(var item in result)
            {
                if (item.Status == true)
                    item.StatusString = "DA";
                foreach(var item2 in result2)
                {
                    if (item.KorisnikId == item2.KorisnikId)
                    {
                        var uloga = await _uloge.GetById<Model.Uloge>(item2.UlogaId);
                        item.Uloge += uloga.Naziv+", ";
                    }
                }
            }
            dgvKorisnici.DataSource = result;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest search = new KorisniciSearchRequest() { 
                Ime=txtImePretraga.Text,
                Prezime=txtPrezimePretraga.Text
            };
            var result = await _korisnici.Get<List<Model.Korisnici>>(search);
            var result2 = await _korisnickeUloge.Get<List<Model.KorisnickeUloge>>(null);

            foreach (var item in result)
            {
                if (item.Status == true)
                    item.StatusString = "DA";
                foreach (var item2 in result2)
                {
                    if (item.KorisnikId == item2.KorisnikId)
                    {
                        var uloga = await _uloge.GetById<Model.Uloge>(item2.UlogaId);
                        item.Uloge += uloga.Naziv + ", ";
                    }
                }
            }
            dgvKorisnici.DataSource = result;
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int idKorisnika = int.Parse(dgvKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeKorisnika frm = new frmDodavanjeKorisnika(idKorisnika);
            frm.ShowDialog();
        }
    }
}
