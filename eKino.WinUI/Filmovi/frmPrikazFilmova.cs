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

namespace eKino.WinUI.Filmovi
{
    public partial class frmPrikazFilmova : Form
    {
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _filmoviZanrovi = new APIService("FilmoviZanrovi");
        public frmPrikazFilmova()
        {
            InitializeComponent();
            dgvPrikazFilmova.AutoGenerateColumns = false;
        }

        private async void frmPrikazFilmova_Load(object sender, EventArgs e)
        {
            var result = await _filmovi.Get<List<Model.Filmovi>>(null);
            var result2 = await _filmoviZanrovi.Get<List<Model.FilmoviZanrovi>>(null);
            var result3 = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            clbZanrovi.DataSource = result3;
            foreach (var item in result)
            {
                foreach (var x in result2)
                {
                    if (x.FilmId == item.FilmId)
                    {
                        var zanr = await _zanrovi.GetById<Model.Zanrovi>(x.ZanrId);
                        item.Zanrovi += $"{zanr.Naziv}, ";
                    }
                }
            }
            dgvPrikazFilmova.DataSource = result;
        }
        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            
            FilmoviSearchRequest search = new FilmoviSearchRequest() {
                Naziv = txtNaziv.Text,
                Zanrovi = clbZanrovi.CheckedItems.Cast<Model.Zanrovi>().Select(a => a.ZanrId).ToList()
            };
            if (dtpDatumIzdavanja.Value.Year!=1753) {
                search.DatumIzdavanja = dtpDatumIzdavanja.Value;
            }
            else {
                search.DatumIzdavanja = null;
            }
            var result=await _filmovi.Get<List<Model.Filmovi>>(search);
            var result2 = await _filmoviZanrovi.Get<List<Model.FilmoviZanrovi>>(null);
            foreach (var item in result)
            {
                foreach (var x in result2)
                {
                    if (x.FilmId == item.FilmId)
                    {
                        var zanr = await _zanrovi.GetById<Model.Zanrovi>(x.ZanrId);
                        item.Zanrovi += $"{zanr.Naziv}, ";
                    }
                }
            }
                dgvPrikazFilmova.DataSource = result;
        }

        private void dgvPrikazFilmova_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idFilma = int.Parse(dgvPrikazFilmova.SelectedRows[0].Cells[0].Value.ToString());
            frmDodavanjeFilmova frm = new frmDodavanjeFilmova(idFilma);
            frm.ShowDialog();
        }

        private void dtpDatumIzdavanja_MouseDown(object sender, MouseEventArgs e)
        {
            dtpDatumIzdavanja.CustomFormat = "dd/MM/yyyy";
        }
    }
}