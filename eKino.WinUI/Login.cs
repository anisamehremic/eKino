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

namespace eKino.WinUI
{
    public partial class Login : Form
    {
        private readonly APIService _login = new APIService("Drzave");
        private readonly APIService _korisniciService = new APIService("Korisnici");//amel
        public Login()
        {
            InitializeComponent();
        }
        private async void btn_PrijaviSe_Click_1(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txt_KorisnickoIme.Text;
                APIService.Password = txt_Sifra.Text;
                await _login.Get<dynamic>(null);

                var list = await _korisniciService.Get<List<Model.Korisnici>>(new KorisniciUpsertRequest() { KorisnickoIme = APIService.Username});//-----------------------
                if (list.Count == 1)
                {
                    this.Hide();
                    Pocetna frm = new Pocetna();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Prijavite se kao korsinik(admin, radnik)!");//-------------------------
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
