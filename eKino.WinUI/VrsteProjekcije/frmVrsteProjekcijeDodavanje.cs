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

namespace eKino.WinUI.VrsteProjekcije
{
    public partial class frmVrsteProjekcijeDodavanje : Form
    {
        private int? Id=null;
        private readonly APIService _vrsteProjekcije = new APIService("VrsteProjekcije");
        public frmVrsteProjekcijeDodavanje(int? vrstaProjekcijeId=null)
        {
            InitializeComponent();
            Id = vrstaProjekcijeId;
        }

        private async void frmProjekcijeDodavanje_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                var result =await _vrsteProjekcije.GetById<Model.VrsteProjekcije>(Id);
                txtVrsta.Text = result.Naziv;
                txtOpis.Text = result.Opis;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VrsteProjekcijeUpsertRequest request = new VrsteProjekcijeUpsertRequest()
            {
                Naziv=txtVrsta.Text,
                Opis=txtOpis.Text
            };

            if (Id != null)
            {
                var result= await _vrsteProjekcije.Update<Model.VrsteProjekcije>(Id, request);
                if (result != null)
                {
                    MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                }
            }
            else
            {
                var result = await _vrsteProjekcije.Insert<Model.VrsteProjekcije>(request);
                if (result != null)
                {
                    MessageBox.Show(Properties.Resources.UspjesnoDodano);
                }
            }
        }

        private void txtVrsta_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtVrsta, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
