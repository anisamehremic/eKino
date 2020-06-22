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
using Flurl.Http;
using System.Text.RegularExpressions;

namespace eKino.WinUI.Korisnici
{
    public partial class frmDodavanjeKorisnika : Form
    {
        private int? Id = null;
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _uloge = new APIService("Uloge");
        private readonly APIService _korisnickeUloge = new APIService("KorisnickeUloge");
        public frmDodavanjeKorisnika(int? korisnikId=null)
        {
            InitializeComponent();
            Id = korisnikId;
        }

        private async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            int id = Id ?? 0;
            foreach (var item in result)
                if (item.KorisnickoIme == txtKorIme.Text && item.KorisnikId != id)
                {
                    errorProvider.SetError(txtKorIme, "Korisničko ime već postoji!");
                    return false;
                }
            errorProvider.SetError(txtKorIme, null);
            return true;
        }

        private async Task<bool> txtEmail_Validating()
        {
            var result = await _korisnici.Get<List<Model.Korisnici>>(null);
            int id = Id ?? 0;
            foreach (var item in result)
                if (item.Email == txtEmail.Text && item.KorisnikId != id)
                {
                    errorProvider.SetError(txtEmail, "Email već postoji.");
                    return false;
                }
            errorProvider.SetError(txtEmail, null);
            return true;
        }

        private bool txtLozinka_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                if (Id.HasValue)
                {
                    errorProvider.SetError(txtSifra, null);
                    errorProvider.SetError(txtSifraPotvrda, null);
                    return true;
                }
                else
                {
                    errorProvider.SetError(txtSifra, Properties.Resources.ObaveznoPolje);
                    errorProvider.SetError(txtSifraPotvrda, Properties.Resources.ObaveznoPolje);
                    return false;
                }
            }
            else if (txtSifra.Text != txtSifraPotvrda.Text)
            {
                errorProvider.SetError(txtSifra, "Passwordi se ne slažu");
                errorProvider.SetError(txtSifraPotvrda, "Passwordi se ne slažu");
                return false;
            }
            errorProvider.SetError(txtSifra, null);
            errorProvider.SetError(txtSifraPotvrda, null);
            return true;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtLozinka_Validating() && await txtKorisnickoIme_Validating() && await txtEmail_Validating())
            {
                KorisniciUpsertRequest request = new KorisniciUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorIme.Text,
                    Telefon = txtTelefon.Text,
                    Sifra = txtSifra.Text,
                    SifraPotvrda = txtSifraPotvrda.Text,
                    Status = chbStatus.Checked,
                    DatumRodjenja=dtpRodjenje.Value,
                    Uloge = clbKorisnickeUloge.CheckedItems.Cast<Model.Uloge>().Select(a => a.UlogaId).ToList()
                };
                if (Id == null)
                {
                    try
                    {
                        var result = await _korisnici.Insert<Model.Korisnici>(request);
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
                    try { 
                    var result = await _korisnici.Update<Model.Korisnici>(Id, request);
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

        private async void frmDodavanjeKorisnika_Load(object sender, EventArgs e)
        {
            var result = await _uloge.Get<List<Model.Uloge>>(null);
            clbKorisnickeUloge.DataSource= result;
            clbKorisnickeUloge.DisplayMember= "Naziv";
            clbKorisnickeUloge.ValueMember= "UlogaId";
            if (Id != null)
            {
                var korisnik =await _korisnici.GetById<Model.Korisnici>(Id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtKorIme.Text = korisnik.KorisnickoIme;
                txtTelefon.Text = korisnik.Telefon;
                dtpRodjenje.Value = korisnik.DatumRodjenja;
                chbStatus.Checked = korisnik.Status==true?true:false;
                var uloge = await _korisnickeUloge.Get<List<Model.KorisnickeUloge>>(null);
                var ulogekorisnika = uloge.Where(a => a.KorisnikId == korisnik.KorisnikId);
                foreach(var item in ulogekorisnika)
                {
                    for(int i=0; i<clbKorisnickeUloge.Items.Count; i++)
                    {
                        var u = (Model.Uloge)clbKorisnickeUloge.Items[i];
                        if(item.UlogaId==u.UlogaId)
                        clbKorisnickeUloge.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtIme.Text, @"^[a-zA-Z]+$"))
            {
                errorProvider.SetError(txtIme, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrezime.Text, @"^[a-zA-Z]+$"))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}$") &&
                !Regex.IsMatch(txtTelefon.Text,@"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{4}$"))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else if(!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtKorIme_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtKorIme, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (Id != null)
            {
                Validator.ObaveznoPoljeTxt(txtSifra, e, errorProvider, Properties.Resources.ObaveznoPolje);

                if (!Regex.IsMatch(txtSifra.Text, @"^[a-zA-Z0-9 @%&#$()?*-/]{12,}$"))
                {
                    errorProvider.SetError(txtSifra, Properties.Resources.SifraFormat);
                    e.Cancel = true;
                }
            }
        }

        private void txtSifraPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if(Id!=null)
            Validator.ObaveznoPoljeTxt(txtSifraPotvrda, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void clbKorisnickeUloge_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeClb(clbKorisnickeUloge, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void dtpRodjenje_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(dtpRodjenje, e, errorProvider, Properties.Resources.ObaveznoPolje);

        }
    }
}
