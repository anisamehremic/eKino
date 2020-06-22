using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKino.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }
        public string StatusString { get; set; }
        public string Uloge { get; set; }
        public virtual ICollection<KorisnickeUloge> KorisnickeUloge { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime + "-" + KorisnickoIme;
        }
    }
}
