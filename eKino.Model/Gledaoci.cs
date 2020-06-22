using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKino.Model
{
    public class Gledaoci
    {
        public int GledalacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Ispis { get { return $"{Ime} {Prezime} {KorisnickoIme}"; } }
        public bool? Status { get; set; }
        public string StatusString { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
