using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Ulaznice
{
    public partial class frmUlazniceDetalji : Form
    {
        private int? Id = null;
        private readonly APIService _ulaznice = new APIService("Ulaznice");
        public frmUlazniceDetalji(int? ulaznicaId=null)
        {
            InitializeComponent();
            Id = ulaznicaId;
        }

        private async void frmUlazniceDetalji_Load(object sender, EventArgs e)
        {
            var ulaznica =await _ulaznice.GetById<Model.Ulaznice>(Id);
            film.Text = ulaznica.Projekcija.Film.Naziv;
            sjediste.Text = ulaznica.Sjediste.Ispis;
            vrijemeSala.Text = ulaznica.Projekcija.Sala.Naziv;
            brojUlaznice.Text = ulaznica.UlaznicaId.ToString();
                
            MemoryStream stream = new MemoryStream(ulaznica.Projekcija.Film.Slika);
                slikaFilma.Image = Image.FromStream(stream);
           
            MemoryStream stream2 = new MemoryStream(ulaznica.Qrcode);
                qrKod.Image = Image.FromStream(stream2);
        }

    }
}
