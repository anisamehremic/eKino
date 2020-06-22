using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            Ulaznice = new HashSet<Ulaznice>();
        }

        public int RezervacijaId { get; set; }
        public int? GledalacId { get; set; }
        public int ProjekcijaId { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int BrojKarata { get; set; }
        public bool? Status { get; set; }
        public decimal Cijena { get; set; }

        public virtual Gledaoci Gledalac { get; set; }
        public virtual Projekcije Projekcija { get; set; }
        public virtual ICollection<Ulaznice> Ulaznice { get; set; }
    }
}
