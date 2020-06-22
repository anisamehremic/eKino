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

namespace eKino.WinUI.Države
{
    public partial class frmDodavanjeDrzava : Form
    {
        public int? Id = null;

        private readonly APIService _drzave = new APIService("Drzave");
        public frmDodavanjeDrzava(int? DrzavaId=null)
        {
            InitializeComponent();
            Id = DrzavaId;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DrzaveUpsertRequest request = new DrzaveUpsertRequest()
                {
                    Naziv = txtNazivDrzave.Text
                };
                if (Id == null)
                {
                    var result = _drzave.Insert<Model.Drzave>(request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                    }
                }
                else
                {
                    var result = _drzave.Update<Model.Drzave>(Id, request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                    }
                }
            }
        }
        private async void frmDodavanjeDrzava_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
            var result = await _drzave.GetById<Model.Drzave>(Id);
                txtNazivDrzave.Text = result.Naziv;
            }
        }
        private void txtNazivDrzave_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNazivDrzave, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
