using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class VrsteProjekcije
    {
        public VrsteProjekcije()
        {
            Projekcije = new HashSet<Projekcije>();
        }

        public int VrstaProjekcijeId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Projekcije> Projekcije { get; set; }
    }
}
