using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int GledalacId { get; set; }
        public int FilmId { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumOcjenjivanja { get; set; }

        public virtual Filmovi Film { get; set; }
        public virtual Gledaoci Gledalac { get; set; }
    }
}
