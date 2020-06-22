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

namespace eKino.WinUI.Rezervacije
{
    public partial class frmPrikazRezervacija : Form
    {
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _gledaoci = new APIService("Gledaoci");
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _sale = new APIService("Sale");
        public frmPrikazRezervacija()
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
        }

        private async void frmPrikazRezervacija_Load(object sender, EventArgs e)
        {                        
            var result =await _rezervacije.Get<List<Model.Rezervacije>>(null);
            foreach(var item in result)
            {
                if (item.Status==true)
                {
                    item.StatusString = "DA";
                }
            }
            dgvRezervacije.DataSource = result;
        }

        private void dgvRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int rezervacijaId = int.Parse(dgvRezervacije.SelectedRows[0].Cells[0].Value.ToString());
            frmDodajUrediRezervaciju frm = new frmDodajUrediRezervaciju(rezervacijaId);
            frm.ShowDialog();
        }

        private void dtpDatumRezervacije_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDatumRezervacije.CustomFormat = "dd/MM/yyyy";
        }

        private async  void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijeSearchRequest request = new RezervacijeSearchRequest() {
                DatumRezervacije = dtpDatumRezervacije.Value,
            };
            if (dtpDatumRezervacije.Value.Year != 1753)
            {
                request.DatumRezervacije = dtpDatumRezervacije.Value;
            }
            else
            {
                request.DatumRezervacije = null;
                request = null;
            }
            var result = await _rezervacije.Get<List<Model.Rezervacije>>(request);

            dgvRezervacije.DataSource = result;
        }

        private void dtpDatumRezervacije_MouseDown_1(object sender, MouseEventArgs e)
        {
            dtpDatumRezervacije.CustomFormat = "dd/MM/yyyy";
        }
    }
}
