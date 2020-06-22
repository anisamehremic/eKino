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

namespace eKino.WinUI.FilmskeLičnosti
{
    public partial class frmDodavanjeFilmskihLicnosti : Form
    {
        private int? Id = null;
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _flimskeLicnosti = new APIService("FilmskeLicnosti");
        public frmDodavanjeFilmskihLicnosti(int? filmskaLicnostId=null)
        {
            InitializeComponent();
            Id = filmskaLicnostId;
           
        }
        private async void frmDodavanjeFilmskihLicnosti_Load(object sender, EventArgs e)
        {
            var drzave = await _drzave.Get<List<Model.Drzave>>(null);
            drzave.Insert(0, new Model.Drzave { });
            cmbDrzava.DataSource = drzave;
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "DrzavaId";
            if (Id != null)
            {
            var filmskaLicnost = await _flimskeLicnosti.GetById<Model.FilmskeLicnosti>(Id);
                txtIm.Text = filmskaLicnost.Ime;
                txtPrezim.Text = filmskaLicnost.Prezime;
                cmbDrzava.SelectedValue = filmskaLicnost.DrzavaId;
                dtpDatuRodjenj.Value = filmskaLicnost.DatumRodjenja;
                request.Slika = filmskaLicnost.Slika;
                request.SlikaThumb = filmskaLicnost.SlikaThumb;
                MemoryStream stream = new MemoryStream(filmskaLicnost.Slika);
                pictureBox.Image = Image.FromStream(stream);
                txtSlika.Text = "Ovdje učitajte novu sliku.";
            }
        }
        FilmskeLicnostiUpsertRequest request = new FilmskeLicnostiUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                request.Ime = txtIm.Text;
                request.Prezime = txtPrezim.Text;
                request.DatumRodjenja = dtpDatuRodjenj.Value;
                request.DrzavaId = int.Parse(cmbDrzava.SelectedValue.ToString());
                if (Id != null)
                {
                    var result = await _flimskeLicnosti.Update<Model.FilmskeLicnosti>(Id, request);

                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
                else
                {
                    var result = await _flimskeLicnosti.Insert<Model.FilmskeLicnosti>(request);

                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                    }
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                var file = File.ReadAllBytes(filename);
                request.Slika = file;
                request.SlikaThumb = file;
                txtSlika.Text = filename;

                Image image = Image.FromFile(filename);
                pictureBox.Image = image;
            }
        }

        private void txtIm_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtIm, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtPrezim_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtPrezim, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtSlika, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtpDatuRodjenj_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(dtpDatuRodjenj, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmbDrzava_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbDrzava, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
