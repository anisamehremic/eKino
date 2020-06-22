using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class FilmskeLicnostiUpsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        [Required]
        public int DrzavaId { get; set; }
    }
}
