using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int FilmId { get; set; }
        public int GledalacId { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumOcjenjivanja { get; set; }

        public virtual Filmovi Film { get; set; }
        public virtual Gledaoci Gledalac { get; set; }
    }
}
