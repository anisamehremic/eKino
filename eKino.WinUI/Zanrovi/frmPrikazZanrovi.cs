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
    public partial class frmPrikazZanrovi : Form
    {
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        public frmPrikazZanrovi()
        {
            InitializeComponent();
        }

        private async void frmPrikazZanrovi_Load(object sender, EventArgs e)
        {
            var result =await _zanrovi.Get<List<Model.Zanrovi>>(null);
            dgvZanrovi.DataSource = result;
        }

        private void dgvZanrovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idZanra= int.Parse(dgvZanrovi.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeZanrovi frm = new frmDodavanjeZanrovi(idZanra);
            frm.ShowDialog();
        }
    }
}
