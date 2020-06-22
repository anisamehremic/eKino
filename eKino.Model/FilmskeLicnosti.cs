using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class FilmskeLicnosti
    {
        public int FilmskaLicnostId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
        public string Ispis { get { return Ime + " " + Prezime; } }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
