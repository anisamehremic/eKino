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

namespace eKino.WinUI.Sale
{
    public partial class frmDodavanjeSala : Form
    {
        private int? Id = null;
        private readonly APIService _sale = new APIService("Sale");
        public frmDodavanjeSala(int? IdSale=null)
        {
            InitializeComponent();
            Id = IdSale;
        }
        SaleUpsertRequest request = new SaleUpsertRequest();
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.BrojSjedista = (int)numBrojSjedista.Value;
                request.Opis = txtOpis.Text;

                if (Id != null)
                {
                    var result = _sale.Update<Model.Sale>(Id, request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
                else
                {
                    var result = _sale.Insert<Model.Sale>(request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
            }
        }

        private async void frmDodavanjeSala_Load(object sender, EventArgs e)
        {

            if (Id != null)
            {
                var result = await _sale.GetById<Model.Sale>(Id);
                txtNaziv.Text = result.Naziv;
                txtOpis.Text = result.Opis;
                numBrojSjedista.Value = result.BrojSjedista;
                request.Slika = result.Slika;
                request.SlikaThumb = result.SlikaThumb;
                MemoryStream stream = new MemoryStream(result.Slika);
                pictureBox.Image = Image.FromStream(stream);
                txtSlika.Text = "Ovdje učitajte novu sliku.";
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNaziv, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtSlika, e, errorProvider, Properties.Resources.ObaveznoPolje);
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
        private void numBrojSjedista_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeNumeric(numBrojSjedista, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
