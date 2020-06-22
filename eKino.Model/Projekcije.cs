using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class Projekcije
    {
        public int ProjekcijaId { get; set; }
        public int FilmId { get; set; }
        public Filmovi Film { get; set; }
        public int SalaId { get; set; }
        public Sale Sala { get; set; }
        public DateTime DatumVrijemeOdrzavanja { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaProjekcijeId { get; set; }
        public VrsteProjekcije VrstaProjekcije { get; set; }
        public string FilmSala { get; set;}
        public string CijenaPrikaz { get; set; }
        public string Drzava { get; set; }

        public string Ispis {
            get { return $"{Film?.Naziv ?? " "}   {Sala?.Naziv??" "}   {DatumVrijemeOdrzavanja.ToString("dd.MM.yyyy HH:mm")}"; }
        }
        public override string ToString()
        {
            return$" { Film?.Naziv ?? " "}   {Sala?.Naziv??" "}   {DatumVrijemeOdrzavanja}";
        }
    }
}