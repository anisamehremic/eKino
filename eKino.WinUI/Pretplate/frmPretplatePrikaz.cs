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

namespace eKino.WinUI.Pretplate
{
    public partial class frmPretplatePrikaz : Form
    {
        private readonly APIService _pretplate = new APIService("Pretplate");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        public frmPretplatePrikaz()
        {
            InitializeComponent();
            dgvPretplate.AutoGenerateColumns = false;
        }

        private async void frmPretplatePrikaz_Load(object sender, EventArgs e)
        {
            var result =await _pretplate.Get<List<Model.Pretplate>>(null);
            foreach(var item in result)
            {
                if (item.Otkazana)
                    item.OtkazanaString = "DA";
                else
                    item.OtkazanaString = "NE";
            }
            dgvPretplate.DataSource = result;
            var zanrovi = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            zanrovi.Insert(0, new Model.Zanrovi() { });

            cmbZanrovi.DataSource = zanrovi;
            cmbZanrovi.DisplayMember = "Naziv";
            cmbZanrovi.ValueMember = "ZanrId";
        }

        private async void cmbZanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZanrovi.SelectedIndex > 0)
            {
                PretplateSearchRequest request = new PretplateSearchRequest()
                {
                    ZanrId = int.Parse(cmbZanrovi.SelectedValue.ToString())
                };
                var result = await _pretplate.Get<List<Model.Pretplate>>(request);
                foreach (var item in result)
                {
                    if (item.Otkazana)
                        item.OtkazanaString = "DA";
                    else
                        item.OtkazanaString = "NE";
                }
                dgvPretplate.DataSource = result;
                txtBrojPretplacenih.Text = dgvPretplate.Rows.Count.ToString();
            }
            else {
                var result = await _pretplate.Get<List<Model.Pretplate>>(null);
                foreach (var item in result)
                {
                    if (item.Otkazana)
                        item.OtkazanaString = "DA";
                    else
                        item.OtkazanaString = "NE";
                }
                dgvPretplate.DataSource = result;
                txtBrojPretplacenih.Text = " ";
            }
        }
    }
}
