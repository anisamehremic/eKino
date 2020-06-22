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

namespace eKino.WinUI.FilmskeLičnosti
{
    public partial class frmPrikazFilmskihLicnosti : Form
    {
        private readonly APIService _filmskeLicnosti = new APIService("FilmskeLicnosti");
        private readonly APIService _drzave = new APIService("Drzave");
        public frmPrikazFilmskihLicnosti()
        {
            InitializeComponent();
            dgvFilmskeLicnosti.AutoGenerateColumns = false;
        }

        private async void frmPrikazFilmskihLicnosti_Load(object sender, EventArgs e)
        {
            var result = await _filmskeLicnosti.Get<List<Model.FilmskeLicnosti>>(null);
            dgvFilmskeLicnosti.DataSource=result;
        }

        private void dgvFilmskeLicnosti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idLicnosti = int.Parse(dgvFilmskeLicnosti.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeFilmskihLicnosti frm = new frmDodavanjeFilmskihLicnosti(idLicnosti);
            frm.ShowDialog();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            FilmskeLicnostiSearchRequest search = new FilmskeLicnostiSearchRequest()
            {
                Ime = txtImePretraga.Text,
                Prezime = txtPrezimePretraga.Text
            };
            var result = await _filmskeLicnosti.Get<List<Model.FilmskeLicnosti>>(search);
            dgvFilmskeLicnosti.DataSource = result;
        }
    }
}
