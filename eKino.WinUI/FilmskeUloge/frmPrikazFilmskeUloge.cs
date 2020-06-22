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
    public partial class frmPrikazFilmskeUloge : Form
    {
        private readonly APIService _filmskeUloge = new APIService("FilmskeUloge");
        public frmPrikazFilmskeUloge()
        {
            InitializeComponent();
            dgvfilmskeUloge.AutoGenerateColumns = false;
        }

        private async void frmPrikazFilmskeUloge_Load(object sender, EventArgs e)
        {
            var result =await _filmskeUloge.Get<List<Model.FilmskeUloge>>(null);
            dgvfilmskeUloge.DataSource = result;
        }

        private void dgvfilmskeUloge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idUloge = int.Parse(dgvfilmskeUloge.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeFilmskeUloge frm = new frmDodavanjeFilmskeUloge(idUloge);
            frm.ShowDialog();
        }
    }
}
