using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Notifikacije
    {
        public int NotifikacijaId { get; set; }
        public int? NovostId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumSlanja { get; set; }
        public int GledalacId { get; set; }
        public bool Procitana { get; set; }

        public virtual Gledaoci Gledalac { get; set; }
        public virtual Novosti Novost { get; set; }
    }
}
