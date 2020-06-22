using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Izvjestaji
{
    public partial class frmIzvjestaj : Form
    {
        private readonly APIService _filmovi = new APIService("Filmovi");
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private async void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var filmovi = await _filmovi.Get<List<Model.Filmovi>>(null);
            filmovi.Insert(0, new Model.Filmovi() { });

            cmbFilmovi.DataSource = filmovi;
            cmbFilmovi.DisplayMember = "Naziv";
            cmbFilmovi.ValueMember = "FilmId";
        }

        private void tnPrikazi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var tap = cmbFilmovi.SelectedValue.ToString();
                if (int.TryParse(tap, out int id))
                {

                    frmIzvjestajFilm frm = new frmIzvjestajFilm(id);
                    frm.Show();
                }
            }
        }

        private void cmbFilmovi_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbFilmovi, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
