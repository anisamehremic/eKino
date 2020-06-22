using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Notifikacije
    {
        public int NotifikacijaId { get; set; }
        public int? NovostId { get; set; }
        public int GledalacId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool Procitana { get; set; }
        public Novosti Novost { get; set; }
        public Gledaoci Gledalac { get; set; }
    }
}
