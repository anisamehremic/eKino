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

namespace eKino.WinUI.Ulaznice
{
    public partial class frmUlaznicePrikaz : Form
    {
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        private readonly APIService _projekcije = new APIService("Projekcije");
        public frmUlaznicePrikaz()
        {
            InitializeComponent();
            dgvUlaznice.AutoGenerateColumns = false;
        }

        private async void frmUlaznicePrikaz_Load(object sender, EventArgs e)
        {
            await LoadProjekcije();

            var result =await _ulaznice.Get<List<Model.Ulaznice>>(null);
            foreach(var item in result)
            {
                item.CijenaString = item.Cijena + " KM";
            }
            dgvUlaznice.DataSource = result;
        }

        public async Task LoadProjekcije() {
            var projekcije = await _projekcije.Get<List<Model.Projekcije>>(null);
            projekcije.Insert(0, new Model.Projekcije() { });
            cmbProjekcije.DataSource = projekcije;
            cmbProjekcije.DisplayMember = "Ispis";
            cmbProjekcije.ValueMember = "ProjekcijaId";
        }

        private void dgvUlaznice_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var ulaznicaId= int.Parse(dgvUlaznice.SelectedRows[0].Cells[0].Value.ToString());
            frmUlazniceDetalji frm = new frmUlazniceDetalji(ulaznicaId);
            frm.ShowDialog();
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            UlazniceSearchRequest search = new UlazniceSearchRequest() { Neaktivne = false, Aktivne = false };

            var objProjekcije = cmbProjekcije.SelectedValue;
            search.ProjekcijaId = int.Parse(objProjekcije?.ToString() ?? "0");

            if (cbAktivne.Checked != cbNeaktivne.Checked) {
                if (cbAktivne.Checked == true) { 
                    search.Aktivne = true;
                }
                if (cbNeaktivne.Checked == true)
                {
                    search.Neaktivne = true;
                }
            }

            var result = await _ulaznice.Get<List<Model.Ulaznice>>(search);
            foreach (var item in result)
            {
                item.CijenaString = item.Cijena + " KM";
            }
            dgvUlaznice.DataSource = result;
        }
    }
}
