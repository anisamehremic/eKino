using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class FilmoviUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public DateTime DatumSnimanja { get; set; }
        public string Opis { get; set; }
        [Required]
        public int Trajanje { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        [Required]
        public int DrzavaId { get; set; }
        public List<int> Zanrovi { get; set; }
    }
}
