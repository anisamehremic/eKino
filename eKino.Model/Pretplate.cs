using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Pretplate
    {
        public int PretplataId { get; set; }
        public int ZanrId { get; set; }
        public int GledalacId { get; set; }
        public DateTime? DatumPretplate { get; set; }
        public bool Otkazana { get; set; }
        public string OtkazanaString { get; set; }

        public virtual Gledaoci Gledalac { get; set; }
        public virtual Zanrovi Zanr { get; set; }
    }
}
