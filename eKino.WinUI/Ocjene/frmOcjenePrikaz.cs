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

namespace eKino.WinUI.Ocjene
{
    public partial class frmOcjenePrikaz : Form
    {
        private readonly APIService _ocjene = new APIService("Ocjene");
        private readonly APIService _filmovi = new APIService("Filmovi");
        public frmOcjenePrikaz()
        {
            InitializeComponent();
            dgvOcjene.AutoGenerateColumns = false;
        }

        private async void frmOcjenePrikaz_Load(object sender, EventArgs e)
        {
            var result =await _ocjene.Get<List<Model.Ocjene>>(null);
            dgvOcjene.DataSource = result;
            var filmovi =await _filmovi.Get<List<Model.Filmovi>>(null);
            filmovi.Insert(0, new Model.Filmovi(){ });
            cmbFilmovi.DataSource = filmovi;
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmId";
        }

        private async void cmbFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilmovi.SelectedIndex > 0)
            {
                txtProsjecnaOcjena.Text = "";

                var prosjek = 0;
                var brojac = 0;
                OcjeneSearchRequest request = new OcjeneSearchRequest()
                {
                    FilmId = int.Parse(cmbFilmovi.SelectedValue.ToString())
                };
                var result = await _ocjene.Get<List<Model.Ocjene>>(request);
                dgvOcjene.DataSource = result;
                foreach (var item in result)
                {
                    prosjek += item.Ocjena;
                    brojac++;
                }
                if (brojac > 0)
                {
                    txtProsjecnaOcjena.Text = (prosjek / brojac).ToString();
                }
            }
            else {
                txtProsjecnaOcjena.Text = " ";
                var result = await _ocjene.Get<List<Model.Ocjene>>(null);
                dgvOcjene.DataSource = result;
            }
        }

    }
}
