using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Gledaoci
{
    public partial class frmGledaociDodavanje : Form
    {
        private int? Id = null;
        private readonly APIService _gledaoci = new APIService("Gledaoci");

        public frmGledaociDodavanje(int? gledalacId=null)
        {
            InitializeComponent();
            Id = gledalacId;
        }

        private async void frmGledaociDodavanje_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                var gledalac = await _gledaoci.GetById<Model.Gledaoci>(Id);
                txtIme.Text = gledalac.Ime;
                txtPrezime.Text = gledalac.Prezime;
                txtEmail.Text = gledalac.Email;
                txtKorIme.Text = gledalac.KorisnickoIme;
                txtTelefon.Text = gledalac.Telefon;
                chbStatus.Checked = gledalac.Status == true ? true : false;
                dtpRodjenje.Value = gledalac.DatumRodjenja;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && txtLozinka_Validating() && await txtKorisnickoIme_Validating() && await txtEmail_Validating())
            {
                GledaociUpsertRequest request = new GledaociUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorIme.Text,
                    Telefon = txtTelefon.Text,
                    Sifra = txtSifra.Text,
                    SifraPotvrda = txtSifraPotvrda.Text,
                    Status = chbStatus.Checked,
                    DatumRodjenja = dtpRodjenje.Value,
                };
                if (Id == null)
                {
                    try
                    {
                        var result = await _gledaoci.Insert<Model.Gledaoci>(request);
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
                        var result = await _gledaoci.Update<Model.Gledaoci>(Id, request);
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

        private async Task<bool> txtKorisnickoIme_Validating()
        {
            var result = await _gledaoci.Get<List<Model.Gledaoci>>(null);
            int id = Id ?? 0;
            foreach (var item in result)
                if (item.KorisnickoIme == txtKorIme.Text && item.GledalacId != id)
                {
                    errorProvider.SetError(txtKorIme, "Korisničko ime je zauzeto");
                    return false;
                }
            errorProvider.SetError(txtKorIme, null);
            return true;
        }

        private async Task<bool> txtEmail_Validating()
        {
            var result = await _gledaoci.Get<List<Model.Gledaoci>>(null);
            int id = Id ?? 0;
            foreach (var item in result)
                if (item.Email == txtEmail.Text && item.GledalacId != id)
                {
                    errorProvider.SetError(txtEmail, "Email je iskorišćen");
                    return false;
                }
            errorProvider.SetError(txtEmail, null);
            return true;
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
            else if (!Regex.IsMatch(txtTelefon.Text, @"^[+]?\d{3}[ ]?\d{2}[ ]?\d{3}[ ]?\d{3}"))
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
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.NeispravanFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void dtpRodjenje_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeDtp(dtpRodjenje, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

        private void txtKorIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorIme.Text))
            {
                errorProvider.SetError(txtKorIme, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
            if (!Regex.IsMatch(txtKorIme.Text, @"^[A-Za-z0-9 #$%&*.]{3,}$"))
            {
                errorProvider.SetError(txtKorIme, Properties.Resources.SifraFormat);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorIme, null);
            }

        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                errorProvider.SetError(txtSifra, Properties.Resources.ObaveznoPolje);
                e.Cancel = true;
            }
            else
                if (!Regex.IsMatch(txtSifra.Text, @"^[a-zA-Z0-9 @%&#$()?*-/]{12,}$"))
                {
                    errorProvider.SetError(txtSifra, Properties.Resources.SifraFormat);
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtSifra, null);
                }
        }
        private void txtSifraPotvrda_Validating(object sender, CancelEventArgs e)
        {
            Validator.ObaveznoPoljeTxt(txtSifraPotvrda, e, errorProvider, Properties.Resources.ObaveznoPolje);
        }

    }
}
