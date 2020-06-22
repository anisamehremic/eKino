using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Filmovi
    {
        public int FilmId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumSnimanja { get; set; }
        public string Opis { get; set; }
        public int Trajanje { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int DrzavaId { get; set; }
        public virtual Drzave Drzava { get; set; }
        public ICollection<FilmoviZanrovi> FilmoviZanrovi { get; set; }
        public string Zanrovi { get; set; } = "";
        public string NA = "N/A";

        public override string ToString()
        {
            return Naziv;
        }
    }
}