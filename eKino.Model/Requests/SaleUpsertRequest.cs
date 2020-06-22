using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class SaleUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int BrojSjedista { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Opis { get; set; }
    }
}
