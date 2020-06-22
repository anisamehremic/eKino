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

namespace eKino.WinUI.FilmskeUloge
{
    public partial class frmDodavanjeFilmskeUloge : Form
    {
        public int? Id = null;
        private readonly APIService _filmskeUloge = new APIService("FilmskeUloge");
        public frmDodavanjeFilmskeUloge(int? filmskaUlogaId=null)
        {
            InitializeComponent();
            Id = filmskaUlogaId;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            FilmskeUlogeUpsertRequest request = new FilmskeUlogeUpsertRequest()
            {
                Naziv=txtNaziv.Text,
                Opis=txtOpis.Text
            };

            Model.FilmskeUloge result = null;
            if (Id.HasValue)
            {
                result =await _filmskeUloge.Update<Model.FilmskeUloge>(Id.Value, request);
            }
            else { 
                result =await _filmskeUloge.Insert<Model.FilmskeUloge>(request);
            }
            
            if (result != null)
            {
                MessageBox.Show(Properties.Resources.UspjesnoDodano);
            }
        }

        private async void frmDodavanjeFilmskeUloge_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                var uloga = await _filmskeUloge.GetById<Model.FilmskeUloge>(Id);
                txtNaziv.Text = uloga.Naziv;
                txtOpis.Text = uloga.Opis;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtNaziv, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
