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

namespace eKino.WinUI.Sjedista
{
    public partial class frmSjedistaDodavanje : Form
    {
        public int? Id = null;
        private readonly APIService _sjedista = new APIService("Sjedista");
        private readonly APIService _sale = new APIService("Sale");
        public frmSjedistaDodavanje(int? sjedisteId=null)
        {
            InitializeComponent();
            Id = sjedisteId;
        }

        private async void frmSjedistaDodavanje_Load(object sender, EventArgs e)
        {
            var result = await _sale.Get<List<Model.Sale>>(null);
            result.Insert(0, new Model.Sale() { });
            cmbSale.DataSource = result;
            cmbSale.DisplayMember = "Naziv";
            cmbSale.ValueMember = "SalaId";
            if (Id != null)
            {
                var sjediste = await _sjedista.GetById<Model.Sjedista>(Id);
                cmbSale.SelectedValue = sjediste.SalaId;
                txtRed.Text = sjediste.Red;
                txtKolona.Text = sjediste.Kolona;
                txtOpis.Text = sjediste.Opis;
            }
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                SjedistaUpsertRequest request = new SjedistaUpsertRequest()
                {
                    SalaId=int.Parse(cmbSale.SelectedValue.ToString()),
                    Red=txtRed.Text,
                    Kolona=txtKolona.Text,
                    Opis=txtOpis.Text
                };
                if (Id == null)
                {
                    var result = await _sjedista.Insert<Model.Sjedista>(request);
                    if (result != null)
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                }
                else
                {
                    var result = await _sjedista.Update<Model.Sjedista>(Id, request);
                    if (result != null)
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                }
            }
        }

        private void cmbSale_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbSale, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtRed_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtRed, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtKolona_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtKolona, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

    }
}
