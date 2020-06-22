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

namespace eKino.WinUI.Zanrovi
{
    public partial class frmDodavanjeZanrovi : Form
    {
        private int? Id=null;
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        public frmDodavanjeZanrovi(int? idZanra=null)
        {
            InitializeComponent();
            Id = idZanra;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            ZanroviUpsertRequest request = new ZanroviUpsertRequest() {
                Naziv=txtNaziv.Text,
                Opis=txtOpis.Text
            };
            if (Id == null)
            {
                var result = _zanrovi.Insert<Model.Zanrovi>(request);
                if (result != null)
                {
                    MessageBox.Show(Properties.Resources.UspjesnoDodano);
                }
            }
            else
            {
                var result = _zanrovi.Update<Model.Zanrovi>(Id, request);
                if (result != null)
                {
                    MessageBox.Show(Properties.Resources.UspjesnoDodano);
                }
            }
            
        }

        private async void frmDodavanjeZanrovi_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                var result = await _zanrovi.GetById<Model.Zanrovi>(Id);
                txtNaziv.Text = result.Naziv;
                txtOpis.Text = result.Opis;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNaziv, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
