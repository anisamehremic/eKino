using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Sale
{
    public partial class frmPrikazSala : Form
    {
        private readonly APIService _sale = new APIService("Sale");

        public frmPrikazSala()
        {
            InitializeComponent();
        }

        private void dgvSale_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idSale = int.Parse(dgvSale.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeSala frm = new frmDodavanjeSala(idSale);
            frm.ShowDialog();
        }

        private async void frmPrikazSala_Load(object sender, EventArgs e)
        {
            var result = await _sale.Get<List<Model.Sale>>(null);
            dgvSale.DataSource = result;
        }
    }
}
