using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Sjedista
    {
        public Sjedista()
        {
            Ulaznice = new HashSet<Ulaznice>();
        }

        public int SjedisteId { get; set; }
        public string Opis { get; set; }
        public int SalaId { get; set; }
        public string Red { get; set; }
        public string Kolona { get; set; }
        public bool? Zauzeto { get; set; }

        public virtual Sale Sala { get; set; }
        public virtual ICollection<Ulaznice> Ulaznice { get; set; }
    }
}
