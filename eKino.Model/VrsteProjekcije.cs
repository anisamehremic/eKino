using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class VrsteProjekcije
    {
        public int VrstaProjekcijeId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
