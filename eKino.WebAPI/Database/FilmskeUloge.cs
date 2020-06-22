using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class FilmskeUloge
    {
        public FilmskeUloge()
        {
            FilmoviFilmskeLicnosti = new HashSet<FilmoviFilmskeLicnosti>();
        }

        public int FilmskaUlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<FilmoviFilmskeLicnosti> FilmoviFilmskeLicnosti { get; set; }
    }
}
