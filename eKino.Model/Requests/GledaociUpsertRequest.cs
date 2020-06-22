using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class GledaociUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public bool Status { get; set; }
        public string StaraSifra { get; set; }
        public string Sifra { get; set; }
        public string SifraPotvrda { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        public bool Mobilna { get; set; } = false;
    }
}
