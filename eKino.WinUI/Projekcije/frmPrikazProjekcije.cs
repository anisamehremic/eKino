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

namespace eKino.WinUI.Projekcije
{
    public partial class frmPrikazProjekcije : Form
    {
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _sale = new APIService("Sale");
        private readonly APIService _vrsteProjekcije = new APIService("VrsteProjekcije");
        public frmPrikazProjekcije()
        {
            InitializeComponent();
            dgvProjekcije.AutoGenerateColumns = false;
        }

        private async void frmPrikazProjekcije_Load(object sender, EventArgs e)
        {
            var filmovi = await _filmovi.Get<List<Model.Filmovi>>(null);
            filmovi.Insert(0, new Model.Filmovi() { });
            var sale = await _sale.Get<List<Model.Sale>>(null);
            sale.Insert(0, new Model.Sale() { });
            
            cmbFilmovi.DataSource = filmovi;
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmId";

            cmbSale.DataSource = sale;
            cmbSale.DisplayMember = "Naziv";
            cmbSale.ValueMember = "SalaId";


            var result =await _projekcije.Get<List<Model.Projekcije>>(null);
            foreach(var item in result)
            {
                item.CijenaPrikaz = item.Cijena + " KM";
            }
            
            dgvProjekcije.DataSource = result;
        }

        private void dgvProjekcije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idProjekcije = int.Parse(dgvProjekcije.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeProjekcije frm = new frmDodavanjeProjekcije(idProjekcije);
            frm.ShowDialog();
        }

        private async void tnPrikazi_Click(object sender, EventArgs e)
        {
            ProjekcijeSearchRequest request = new ProjekcijeSearchRequest() {
                FilmId = int.TryParse(cmbFilmovi.SelectedValue.ToString(), out int result1)==true?result1:0,   
                SalaId = int.TryParse(cmbSale.SelectedValue.ToString(), out int result2)==true?result2:0,   
            };
            if (dtpDatumPrikazivanja.Value.Year != 1753)
            {
                request.DatumPrikazivanja = dtpDatumPrikazivanja.Value;
            }
            else
            {
                request.DatumPrikazivanja = null;
            }
            var result =await _projekcije.Get<List<Model.Projekcije>>(request);
            dgvProjekcije.DataSource = result;
        }


        private void dtpDatumPrikazivanja_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDatumPrikazivanja.CustomFormat = "dd/MM/yyyy";
        }
    }
}
