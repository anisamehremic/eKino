using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class FilmskeLicnosti
    {
        public FilmskeLicnosti()
        {
            FilmoviFilmskeLicnosti = new HashSet<FilmoviFilmskeLicnosti>();
        }

        public int FilmskaLicnostId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int DrzavaId { get; set; }

        public virtual Drzave Drzava { get; set; }
        public virtual ICollection<FilmoviFilmskeLicnosti> FilmoviFilmskeLicnosti { get; set; }
    }
}
