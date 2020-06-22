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
    public partial class frmSjedistaPrikaz : Form
    {
        private readonly APIService _sjedista = new APIService("Sjedista");

        public frmSjedistaPrikaz()
        {
            InitializeComponent();
            dgvSjedista.AutoGenerateColumns = false;
        }

        private async void frmSjedistaPrikaz_Load(object sender, EventArgs e)
        {
            var result =await _sjedista.Get<List<Model.Sjedista>>(null);
            dgvSjedista.DataSource = result;
        }

        private void dgvSjedista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int sjedisteId= int.Parse(dgvSjedista.SelectedRows[0].Cells[0].Value.ToString());
            frmSjedistaDodavanje frm = new frmSjedistaDodavanje(sjedisteId);
            frm.ShowDialog();
        }
    }
}
