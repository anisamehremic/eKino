using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Ulaznice
    {
        public int UlaznicaId { get; set; }
        public int? RezervacijaId { get; set; }
        public int ProjekcijaId { get; set; }
        public byte[] Qrcode { get; set; }
        public int SjedisteId { get; set; }
        public decimal Cijena { get; set; }
        public bool? Status { get; set; }
        public int? GledalacId { get; set; }

        public virtual Projekcije Projekcija { get; set; }
        public virtual Rezervacije Rezervacija { get; set; }
        public virtual Sjedista Sjediste { get; set; }
    }
}
