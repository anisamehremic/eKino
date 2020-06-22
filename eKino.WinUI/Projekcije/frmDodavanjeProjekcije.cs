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
    public partial class frmDodavanjeProjekcije : Form
    {
        public int? Id = null;
        private readonly APIService _filmovi = new APIService("Filmovi");
        private readonly APIService _sale = new APIService("Sale");
        private readonly APIService _projekcije = new APIService("Projekcije");
        private readonly APIService _vrsteProjekcije = new APIService("VrsteProjekcije");
        private readonly APIService _notifikacije = new APIService("Notifikacije");
        private readonly APIService _pretplate = new APIService("Pretplate");
        private readonly APIService _filmoviZanrovi = new APIService("FilmoviZanrovi");
        private readonly APIService _rezervacije = new APIService("Rezervacije");
        private readonly APIService _gledaoci = new APIService("Gledaoci");

        public frmDodavanjeProjekcije(int? IdProjekcije=null)
        {
            InitializeComponent();
            Id = IdProjekcije;
        }

        private async void frmDodavanjeProjekcije_Load(object sender, EventArgs e)
        {
                var result = await _filmovi.Get<List<Model.Filmovi>>(null);
                result.Insert(0, new Model.Filmovi());
                var result2 = await _sale.Get<List<Model.Sale>>(null);
                result2.Insert(0, new Model.Sale());
                var vrsteProjekcije = await _vrsteProjekcije.Get<List<Model.VrsteProjekcije>>(null);
                vrsteProjekcije.Insert(0, new Model.VrsteProjekcije() { });

                cmbFilmovi.DataSource = result;
                cmbFilmovi.DisplayMember = "Naziv";
                cmbFilmovi.ValueMember = "FilmId";

                cmbSale.DataSource = result2;
                cmbSale.DisplayMember = "Naziv";
                cmbSale.ValueMember = "SalaId";

                cmbVrstaProjekcije.DataSource = vrsteProjekcije;
                cmbVrstaProjekcije.DisplayMember = "Naziv";
                cmbVrstaProjekcije.ValueMember = "VrstaProjekcijeId";

                Model.Projekcije projekcija = null;
                if (Id != null)
                {
                    projekcija = await _projekcije.GetById<Model.Projekcije>(Id);
                }
                if (projekcija != null)
                {
                    dtpProjekcije.Value = projekcija.DatumVrijemeOdrzavanja;
                    cmbFilmovi.SelectedValue = projekcija.FilmId;
                    cmbSale.SelectedValue = projekcija.SalaId;
                    dtpProjekcije.Value = projekcija.DatumVrijemeOdrzavanja;
                    cmbVrstaProjekcije.SelectedValue = projekcija.VrstaProjekcijeId;
                    numCijena.Value = projekcija.Cijena;
                }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                ProjekcijeUpsertRequest request = new ProjekcijeUpsertRequest()
                {
                    FilmId = int.Parse(cmbFilmovi.SelectedValue.ToString()),
                    SalaId = int.Parse(cmbSale.SelectedValue.ToString()),
                    DatumVrijemeOdrzavanja = dtpProjekcije.Value,
                    Cijena = decimal.Parse(numCijena.Value.ToString()),
                    VrstaProjekcijeId=int.Parse(cmbVrstaProjekcije.SelectedValue.ToString())
                };
                if (Id != null)
                {
                    Model.Projekcije p =await _projekcije.GetById<Model.Projekcije>(Id);
                    var result = await _projekcije.Update<Model.Projekcije>(Id, request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);
                        if (p.DatumVrijemeOdrzavanja != request.DatumVrijemeOdrzavanja) {
                            var rezervacije = await _rezervacije.Get<List<Model.Rezervacije>>(null);
                            var gledaociZaNotifikacijuPromjene = new List<Model.Gledaoci>();
                            foreach(var item in rezervacije)
                            {
                                bool ima = false;
                                foreach(var item2 in gledaociZaNotifikacijuPromjene)
                                {
                                    if (item.GledalacId == item2.GledalacId)
                                    {
                                        ima = true;
                                    }
                                }
                                if (!ima)
                                {
                                    var g = await _gledaoci.GetById<Model.Gledaoci>(item.GledalacId.Value);
                                    gledaociZaNotifikacijuPromjene.Add(g);
                                }
                            }

                            foreach(var item in gledaociZaNotifikacijuPromjene)
                            {
                                NotifikacijeUpsertRequest _notifikacijeUpsert = new NotifikacijeUpsertRequest() {
                                    DatumSlanja = DateTime.Now,
                                    GledalacId = item.GledalacId,
                                    Naslov = "Promjena termina održavanja rezervisane projekcije za film " + p.Film.Naziv+ ". Detalje pogledajte" +
                                    "u sekciji 'Rezervacije'",
                                    Procitana=false
                                };
                                await _notifikacije.Insert<Model.Notifikacije>(_notifikacijeUpsert);
                            }
                        }
                    }
                }
                else
                {
                    var result = await _projekcije.Insert<Model.Projekcije>(request);
                    if (result != null)
                    {
                        MessageBox.Show(Properties.Resources.UspjesnoDodano);

                        //slanje notifikacije svim gledaocima koji su pretplaćeni
                        FilmoviZanroviSearchRequest request4 = new FilmoviZanroviSearchRequest() { 
                            FilmId=result.FilmId
                        };
                        var zanrovi = await _filmoviZanrovi.Get<List<Model.FilmoviZanrovi>>(request4);
                        var pretplate = await _pretplate.Get<List<Model.Pretplate>>(null);
                        foreach(var item in zanrovi)
                        {
                            foreach(var item2 in pretplate)
                            {
                                if (item.ZanrId == item2.ZanrId)
                                {
                                    var film = await _filmovi.GetById<Model.Filmovi>(item.FilmId);
                                    NotifikacijeUpsertRequest request2 = new NotifikacijeUpsertRequest()
                                    {
                                        DatumSlanja = DateTime.Now,
                                        Naslov = "U sekciji 'Projekcije' možete pogledati novu projekciju (" + film.Naziv + ") iz žanra na koji ste pretplećeni.",
                                        Procitana = false,
                                        GledalacId = item2.GledalacId
                                    };
                                    await _notifikacije.Insert<Model.Notifikacije>(request2);
                                }
                            }
                        }

                    }
                }
            }
        }

        private void cmbFilmovi_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbFilmovi, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void cmbSale_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbSale, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtpProjekcije_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(dtpProjekcije, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtpProjekcije_MouseDown(object sender, MouseEventArgs e)
        {
            dtpProjekcije.CustomFormat = "MM/dd/yyyy hh:mm";
        }

        private void cmbVrstaProjekcije_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeCmb(cmbVrstaProjekcije, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }


        private void numCijena_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeNumeric(numCijena, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }
    }
}
