using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class FilmoviFilmskeLicnosti
    {
        public int FilmFilmskaLicnostId { get; set; }
        public int FilmId { get; set; }
        public int FilmskaLicnostId { get; set; }
        public int FilmskaUlogaId { get; set; }

        public virtual Filmovi Film { get; set; }
        public virtual FilmskeLicnosti FilmskaLicnost { get; set; }
        public virtual FilmskeUloge FilmskaUloga { get; set; }
    }
}
