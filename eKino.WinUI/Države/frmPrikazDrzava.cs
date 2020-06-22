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
    public partial class frmPrikazDrzava : Form
    {
        private readonly APIService _drzave = new APIService("Drzave");
        public frmPrikazDrzava()
        {
            InitializeComponent();
        }

        private async void frmPrikazDrzava_Load(object sender, EventArgs e)
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            dgv_PrikazDrzava.DataSource = result;
        }

        private void dgv_PrikazDrzava_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idDrzave = int.Parse(dgv_PrikazDrzava.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeDrzava frm = new frmDodavanjeDrzava(idDrzave);
            frm.ShowDialog();
            
        }
    }
}
