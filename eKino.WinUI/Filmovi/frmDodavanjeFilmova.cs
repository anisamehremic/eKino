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

namespace eKino.WinUI.Filmovi
{
    public partial class frmDodavanjeFilmova : Form
    {
        private int? Id = null;
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _filmoviZanrovi = new APIService("FilmoviZanrovi");

        public frmDodavanjeFilmova(int? filmId=null)
        {
            InitializeComponent();
            Id = filmId;
        }

        FilmoviUpsertRequest request = new FilmoviUpsertRequest();
        private async  void btnSacuvaj_Click(object sender, EventArgs e) {
            if (ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Opis = txtOpis.Text;
                request.DatumSnimanja = dtpDatum.Value;
                request.Trajanje = int.Parse(numaricTrajanje.Value.ToString());
                request.DrzavaId = int.Parse(cmbDrzave.SelectedValue.ToString());
                request.Zanrovi = clabZanrovi.CheckedItems.Cast<Model.Zanrovi>().Select(a => a.ZanrId).ToList();
                if (Id == null)
                {
                    var result = await _filmovi.Insert<Model.Filmovi>(request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                    }
                }
                else
                {
                    var result = await _filmovi.Update<Model.Filmovi>(Id, request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
            }
        }

        private void txtDodajSliku_Click(object sender, EventArgs e)
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

        private async void frmDodavanjeFilmova_Load(object sender, EventArgs e)
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave(){ });
            cmbDrzave.DataSource = result;
            cmbDrzave.DisplayMember = "Naziv";
            cmbDrzave.ValueMember = "DrzavaId";

            var result2 = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            clabZanrovi.DataSource = result2;
            clabZanrovi.DisplayMember = "Naziv";
            clabZanrovi.ValueMember = "ZanrId";
            if (Id != null)
            {
                var film = await _filmovi.GetById<Model.Filmovi>(Id);
                cmbDrzave.SelectedValue = film.DrzavaId;

                var zanrovi = await _filmoviZanrovi.Get<List<Model.FilmoviZanrovi>>(null);
                var list=zanrovi.Where(a=>a.FilmId==film.FilmId).ToList();
                foreach(var item in list)
                {
                    for(int i=0; i<clabZanrovi.Items.Count; i++)
                    {
                        var z=(Model.Zanrovi)clabZanrovi.Items[i];
                        if (item.ZanrId == z.ZanrId)
                        {
                            clabZanrovi.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
                dtpDatum.Value = film.DatumSnimanja;
                txtNaziv.Text = film.Naziv;
                txtOpis.Text = film.Opis;
                numaricTrajanje.Value = film.Trajanje;
                request.Slika = film.Slika;
                request.SlikaThumb = film.SlikaThumb;
                MemoryStream stream = new MemoryStream(film.Slika);
                pictureBox.Image = Image.FromStream(stream);
                txtSlika.Text = "Ovdje učitajte novu sliku.";
            }
        
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNaziv, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtTrajanje_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeNumeric(numaricTrajanje, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtpDatum_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(dtpDatum, e, errorProvider, Properties.Resources.ObaveznoPolje);

        }

        private void clabZanrovi_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeClb(clabZanrovi, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtSlika, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmbDrzave_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbDrzave, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeRtxt(txtOpis, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

    }
}
