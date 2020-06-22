using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.FilmoviFilmskeLicnosti
{
    public partial class frmPrikazFilmoviFilmskeLicnosti : Form
    {
        private readonly APIService _filmoviLicnosti = new APIService("FilmoviFilmskeLicnosti");
        public frmPrikazFilmoviFilmskeLicnosti()
        {
            InitializeComponent();
            dgvFilmoviLicnosti.AutoGenerateColumns = false;
        }

        private async void frmPrikazFilmoviFilmskeLicnosti_Load(object sender, EventArgs e)
        {
            var filmoviLicnosti =await  _filmoviLicnosti.Get<List<Model.FilmoviFilmskeLicnosti>>(null);
            dgvFilmoviLicnosti.DataSource = filmoviLicnosti;
        }

        private void dgvFilmoviLicnosti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var ffl = int.Parse(dgvFilmoviLicnosti.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeFilmoviFilmskeLicnosti frm = new frmDodavanjeFilmoviFilmskeLicnosti(ffl);
            frm.ShowDialog();
        }
    }
}
