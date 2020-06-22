using eKino.WinUI.Države;
using eKino.WinUI.Filmovi;
using eKino.WinUI.FilmoviFilmskeLicnosti;
using eKino.WinUI.FilmskeLičnosti;
using eKino.WinUI.FilmskeUloge;
using eKino.WinUI.Gledaoci;
using eKino.WinUI.Izvjestaji;
using eKino.WinUI.Korisnici;
using eKino.WinUI.Novosti;
using eKino.WinUI.Ocjene;
using eKino.WinUI.Pretplate;
using eKino.WinUI.Projekcije;
using eKino.WinUI.Rezervacije;
using eKino.WinUI.Sale;
using eKino.WinUI.Sjedista;
using eKino.WinUI.Ulaznice;
using eKino.WinUI.VrsteProjekcije;
using eKino.WinUI.Zanrovi;
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
    public partial class Pocetna : Form
    {
        private int childFormNumber = 0;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKorisnika frm = new frmPrikazKorisnika();
            frm.MdiParent = this;
            frm.Show();
        }


        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeKorisnika frm = new frmDodavanjeKorisnika();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazDržavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazDrzava frm = new frmPrikazDrzava();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeDržaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeDrzava frm = new frmDodavanjeDrzava();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazFilmovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazFilmova frm = new frmPrikazFilmova();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeFilmova frm = new frmDodavanjeFilmova();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazFilmskihLičnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazFilmskihLicnosti frm = new frmPrikazFilmskihLicnosti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaFilmskaLičnostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeFilmskihLicnosti frm = new frmDodavanjeFilmskihLicnosti();
            frm.MdiParent = this;
            frm.Show();
        }


        private void prikazFilmskihUlogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazFilmskeUloge frm = new frmPrikazFilmskeUloge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeFilmskeUlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeFilmskeUloge frm = new frmDodavanjeFilmskeUloge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazProjekcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazProjekcije frm = new frmPrikazProjekcije();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeNoveProjekcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeProjekcije frm = new frmDodavanjeProjekcije();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazŽanrovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazZanrovi frm = new frmPrikazZanrovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeNovogŽanraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeZanrovi frm = new frmDodavanjeZanrovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazSala frm = new frmPrikazSala();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeSala frm = new frmDodavanjeSala();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazRezervacija frm = new frmPrikazRezervacija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUrediRezervaciju frm = new frmDodajUrediRezervaciju();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazNovostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazNovosti frm = new frmPrikazNovosti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeNovostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUrediNovosti frm = new frmDodajUrediNovosti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazVrstaProjekcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrsteProjekcijePrikaz frm = new frmVrsteProjekcijePrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeVrsteProjekcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrsteProjekcijeDodavanje frm = new frmVrsteProjekcijeDodavanje();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ulazniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUlaznicePrikaz frm = new frmUlaznicePrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUrediRezervaciju frm = new frmDodajUrediRezervaciju();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazRezervacija frm = new frmPrikazRezervacija();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledGledalacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGledaociPrikaz frm = new frmGledaociPrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeGledalacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGledaociDodavanje frm = new frmGledaociDodavanje();
            frm.ShowDialog();
        }

        private void pregledSjedištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSjedistaPrikaz frm = new frmSjedistaPrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeSjedištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSjedistaDodavanje frm = new frmSjedistaDodavanje();
            frm.ShowDialog();
        }

        private void ocjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOcjenePrikaz frm = new frmOcjenePrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pretplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPretplatePrikaz frm = new frmPretplatePrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazFilmovaIFilmskihLičnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazFilmoviFilmskeLicnosti frm = new frmPrikazFilmoviFilmskeLicnosti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodavanjeFilmskihiLičnostiZaFilmoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeFilmoviFilmskeLicnosti frm = new frmDodavanjeFilmoviFilmskeLicnosti();
            frm.ShowDialog();
        }

        private void filmoviIFilmskeLičnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
