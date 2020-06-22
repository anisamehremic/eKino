using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Pretplate
    {
        public int PretplataId { get; set; }
        public int ZanrId { get; set; }
        public int GledalacId { get; set; }
        public DateTime? DatumPretplate { get; set; }
        public bool Otkazana { get; set; }

        public virtual Gledaoci Gledalac { get; set; }
        public virtual Zanrovi Zanr { get; set; }
    }
}
