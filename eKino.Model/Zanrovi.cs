using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Zanrovi
    {
        public int ZanrId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
