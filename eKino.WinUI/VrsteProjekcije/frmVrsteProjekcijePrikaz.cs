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
    public partial class frmVrsteProjekcijePrikaz : Form
    {
        private readonly APIService _vrsteProjekcije = new APIService("VrsteProjekcije");
        public frmVrsteProjekcijePrikaz()
        {
            InitializeComponent();
            dgvVrsteProjekcije.AutoGenerateColumns = false;
        }

        private async void frmProjekcijePrikaz_Load(object sender, EventArgs e)
        {
            var result = await _vrsteProjekcije.Get<List<Model.VrsteProjekcije>>(null);
            
            dgvVrsteProjekcije.DataSource = result;
        }

        private void dgvVrsteProjekcije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var vrstaProjekcijeID=int.Parse(dgvVrsteProjekcije.SelectedRows[0].Cells[0].Value.ToString());
            frmVrsteProjekcijeDodavanje frm = new frmVrsteProjekcijeDodavanje(vrstaProjekcijeID);
            frm.ShowDialog();
        }
    }
}
