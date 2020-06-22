using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public int? GledalacId { get; set; }
        public Gledaoci Gledalac { get; set; }
        public int ProjekcijaId { get; set; }
        public Projekcije Projekcija { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int BrojKarata { get; set; }
        public bool? Status { get; set; }
        public string StatusString { get; set; }
        public decimal Cijena { get; set; }
        public override string ToString()
        {
            return $"{Gledalac?.KorisnickoIme??" -- "}, film:{Projekcija.Film.Naziv}-- {BrojKarata} karata, {Cijena}KM";
        }
    }
}
