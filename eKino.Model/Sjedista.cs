using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Sjedista
    {
        public int SjedisteId { get; set; }
        public string Opis { get; set; }
        public string Red { get; set; }
        public string Kolona { get; set; }
        public int SalaId { get; set; }
        public virtual Sale Sala { get; set; }
        public bool Zauzeto { get; set; }
        public string Ispis { get { return $"{Red} - {Kolona}"; } }

        public override string ToString()
        {
            return Red + " - " + Kolona;
        }
    }
}
