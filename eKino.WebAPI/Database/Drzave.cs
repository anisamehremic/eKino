using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Drzave
    {
        public Drzave()
        {
            Filmovi = new HashSet<Filmovi>();
            FilmskeLicnosti = new HashSet<FilmskeLicnosti>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Filmovi> Filmovi { get; set; }
        public virtual ICollection<FilmskeLicnosti> FilmskeLicnosti { get; set; }
    }
}
