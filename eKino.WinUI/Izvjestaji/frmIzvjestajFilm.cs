using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKino.Model.Requests;
using Microsoft.Reporting.WinForms;

namespace eKino.WinUI.Izvjestaji
{
    public partial class frmIzvjestajFilm : Form
    {
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _ocjene = new APIService("Ocjene");
        int id;
        public frmIzvjestajFilm(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmIzvjestajFilm_Load(object sender, EventArgs e)
        {
            var film = await _filmovi.GetById<Model.Filmovi>(id);
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Film", film.Naziv));
            rpc.Add(new ReportParameter("Datum", DateTime.Now.ToString("dd.MM.yyyy HH:mm")));


            var rezervacijeList = await _rezervacije.Get<List<Model.Rezervacije>>(null);
            List<Model.Rezervacije> newList = new List<Model.Rezervacije>();
            foreach (var rezervacija in rezervacijeList)
            {
                if (rezervacija.Status == true && rezervacija.Projekcija.FilmId == film.FilmId)
                {
                    newList.Add(rezervacija);
                }
            }
            var ocjeneList = await _ocjene.Get<List<Model.Ocjene>>(new OcjeneSearchRequest() { FilmId = film.FilmId });

            DSFilm.tblFilmoviDataTable tbl = new DSFilm.tblFilmoviDataTable();

            int brojacOcjena = 0;
            float ukupnoKarata = 0;
            decimal ukupnoCijena = 0;
            float prosjecnaOcjena = 0;

            foreach (var rezervacija in newList)
            {
                DSFilm.tblFilmoviRow row = tbl.NewtblFilmoviRow();
                row.NazivProjekcije = rezervacija.ProjekcijaId.ToString();
                row.Gledalac = rezervacija.Gledalac.Ime + " " + rezervacija.Gledalac.Prezime;
                row.Cijena = rezervacija.Cijena;
                row.BrojKarata = rezervacija.BrojKarata;
                row.Ocjena = 0;
                foreach (var ocjena in ocjeneList)
                {
                    if (ocjena.GledalacId == rezervacija.Projekcija.FilmId)
                    {
                        row.Ocjena = ocjena.Ocjena;
                        brojacOcjena++;
                        prosjecnaOcjena += ocjena.Ocjena;
                        break;
                    }
                }
                tbl.Rows.Add(row);
                ukupnoCijena += rezervacija.Cijena;
                ukupnoKarata += rezervacija.BrojKarata;
            }

            if (brojacOcjena != 0)
            {
                prosjecnaOcjena /= brojacOcjena;
                rpc.Add(new ReportParameter("ProsjecnaOcjena", prosjecnaOcjena.ToString()));
            }
            else
            {
                rpc.Add(new ReportParameter("ProsjecnaOcjena", "Nema ocjena"));
            }
            rpc.Add(new ReportParameter("UkupnoKarata", ukupnoKarata.ToString() + " kom"));
            rpc.Add(new ReportParameter("UkupnoCijena", ukupnoCijena.ToString() + " KM"));


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Rezervacije";
            rds.Value = tbl;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
