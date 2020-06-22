using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Ulaznice
    {
        public int UlaznicaId { get; set; }
        public int? RezervacijaId { get; set; }
        public int ProjekcijaId { get; set; }
        public byte[] Qrcode { get; set; }
        public int SjedisteId { get; set; }
        public decimal Cijena { get; set; }
        public string CijenaString { get; set; }
        public bool Status { get; set; }
        public Projekcije Projekcija { get; set; }
        public Rezervacije Rezervacija { get; set; }
        public Sjedista Sjediste { get; set; }

        public int? GledalacId { get; set; }
    }
}
