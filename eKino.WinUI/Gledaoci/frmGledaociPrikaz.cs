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

namespace eKino.WinUI.Gledaoci
{
    public partial class frmGledaociPrikaz : Form
    {
        private readonly APIService _gledaoci = new APIService("Gledaoci");

        public frmGledaociPrikaz()
        {
            InitializeComponent();
            dgvGledaoci.AutoGenerateColumns = false;
        }
        
        private async void frmGledaociPrikaz_Load(object sender, EventArgs e)
        {
            var result = await _gledaoci.Get<List<Model.Gledaoci>>(null);
            foreach(var item in result)
            {
                item.StatusString = item.Status == true ? "DA" : "NE";
            }
            dgvGledaoci.DataSource = result;            
        }

        private void dgvGledaoci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var gledalacId = int.Parse(dgvGledaoci.SelectedRows[0].Cells[0].Value.ToString());
            frmGledaociDodavanje frm = new frmGledaociDodavanje(gledalacId);
            frm.ShowDialog();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            GledaociSearchRequest search = new GledaociSearchRequest()
            {
                Ime = txtImePretraga.Text,
                Prezime = txtPrezimePretraga.Text
            };
            var result = await _gledaoci.Get<List<Model.Gledaoci>>(search);
            foreach (var item in result)
            {
                item.StatusString = item.Status == true ? "DA" : "NE";
            }
            dgvGledaoci.DataSource = result;
        }
    }
}
