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

namespace eKino.WinUI.FilmoviFilmskeLicnosti
{
    public partial class frmDodavanjeFilmoviFilmskeLicnosti : Form
    {
        private readonly APIService _filmoviLicnosti = new APIService("FilmoviFilmskeLicnosti");
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _licnosti = new APIService("FilmskeLicnosti");
        private readonly APIService _uloge = new APIService("FilmskeUloge");

        int? Id = null;
        public frmDodavanjeFilmoviFilmskeLicnosti(int? ffl=null)
        {
            InitializeComponent();
            Id = ffl;
        }

        private async void frmDodavanjeFilmoviFilmskeLicnosti_Load(object sender, EventArgs e)
        {
            var filmovi = await _filmovi.Get<List<Model.Filmovi>>(null);
            filmovi.Insert(0, new Model.Filmovi() { });
            var licnosti = await _licnosti.Get<List<Model.FilmskeLicnosti>>(null);
            licnosti.Insert(0, new Model.FilmskeLicnosti() { });
            var uloge = await _uloge.Get<List<Model.FilmskeUloge>>(null);
            uloge.Insert(0, new Model.FilmskeUloge() { });

            cmbFilm.DataSource = filmovi;
            cmbFilm.DisplayMember = "Naziv";
            cmbFilm.ValueMember = "FilmId";

            cmbLicnost.DataSource = licnosti;
            cmbLicnost.DisplayMember = "Ispis";
            cmbLicnost.ValueMember = "FilmskaLicnostId";

            cmbUloga.DataSource = uloge;
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "FilmskaUlogaId";
            if (Id != null)
            {
                var filmfilmskalicnost = await _filmoviLicnosti.GetById<Model.FilmoviFilmskeLicnosti>(Id);
                cmbFilm.SelectedValue = filmfilmskalicnost.FilmId;
                cmbLicnost.SelectedValue = filmfilmskalicnost.FilmskaLicnostId;
                cmbUloga.SelectedValue = filmfilmskalicnost.FilmskaUlogaId;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                FilmoviFilmskeLicnostiUpsertRequest request = new FilmoviFilmskeLicnostiUpsertRequest()
                {
                    FilmId =int.Parse(cmbFilm.SelectedValue.ToString()),
                    FilmskaLicnostId = int.Parse(cmbLicnost.SelectedValue.ToString()),
                    FilmskaUlogaId = int.Parse(cmbUloga.SelectedValue.ToString()),
                };
                if (Id == null)
                {
                    try
                    {
                        var result = await _filmoviLicnosti.Insert<Model.FilmoviFilmskeLicnosti>(request);
                        if (result != null)
                        {
                            MessageBox.Show(Properties.Resources.UspjesnoDodano);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    try
                    {
                        var result = await _filmoviLicnosti.Update<Model.FilmoviFilmskeLicnosti>(Id, request);
                        if (result != null)
                        {
                            MessageBox.Show(Properties.Resources.UspjesnoPromijenjeno);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }

        }
        private void cmbFilm_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbFilm, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmbLicnost_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbLicnost, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbUloga, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
