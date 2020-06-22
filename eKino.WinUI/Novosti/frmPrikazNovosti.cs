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

namespace eKino.WinUI.Novosti
{
    public partial class frmPrikazNovosti : Form
    {
        private readonly APIService _novosti = new APIService("Novosti");
        public frmPrikazNovosti()
        {
            InitializeComponent();
            dgvNovosti.AutoGenerateColumns = false;
        }

        private async void frmPrikazNovosti_Load(object sender, EventArgs e)
        {
            var novosti =await _novosti.Get<List<Model.Novosti>>(null);
            dgvNovosti.DataSource = novosti;
        }

        private void dgvNovosti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idNovosti = int.Parse(dgvNovosti.SelectedRows[0].Cells[0].Value.ToString());
            frmDodajUrediNovosti frm = new frmDodajUrediNovosti(idNovosti);
            frm.ShowDialog();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NovostiSearchRequest request = new NovostiSearchRequest() {
                DatumObjave=dtpDatumObjave.Value.Date,
                Default="Nije"
            };

            var novosti = await _novosti.Get<List<Model.Novosti>>(request);
            dgvNovosti.DataSource = novosti;
        }

        private void dtpDatumObjave_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDatumObjave.CustomFormat = "dd/MM/yyyy";
        }
    }
}
