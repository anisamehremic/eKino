using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Filmovi
    {
        public Filmovi()
        {
            FilmoviFilmskeLicnosti = new HashSet<FilmoviFilmskeLicnosti>();
            FilmoviZanrovi = new HashSet<FilmoviZanrovi>();
            Ocjene = new HashSet<Ocjene>();
            Projekcije = new HashSet<Projekcije>();
        }

        public int FilmId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumSnimanja { get; set; }
        public string Opis { get; set; }
        public int Trajanje { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzave Drzava { get; set; }
        public virtual ICollection<FilmoviFilmskeLicnosti> FilmoviFilmskeLicnosti { get; set; }
        public virtual ICollection<FilmoviZanrovi> FilmoviZanrovi { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        public virtual ICollection<Projekcije> Projekcije { get; set; }
    }
}
