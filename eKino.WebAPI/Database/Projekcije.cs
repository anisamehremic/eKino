using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Projekcije
    {
        public Projekcije()
        {
            Rezervacije = new HashSet<Rezervacije>();
            Ulaznice = new HashSet<Ulaznice>();
        }

        public int ProjekcijaId { get; set; }
        public int FilmId { get; set; }
        public int SalaId { get; set; }
        public DateTime DatumVrijemeOdrzavanja { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaProjekcijeId { get; set; }

        public virtual Filmovi Film { get; set; }
        public virtual Sale Sala { get; set; }
        public virtual VrsteProjekcije VrstaProjekcije { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
        public virtual ICollection<Ulaznice> Ulaznice { get; set; }
    }
}
