using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class FilmoviZanrovi
    {
        public int FilmZanrId { get; set; }
        public int FilmId { get; set; }
        public int ZanrId { get; set; }

        public virtual Filmovi Film { get; set; }
        public virtual Zanrovi Zanr { get; set; }
    }
}
