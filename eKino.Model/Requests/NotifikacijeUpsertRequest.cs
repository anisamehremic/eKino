using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class NotifikacijeUpsertRequest
    {
        public int? NovostId { get; set; }
        [Required]
        public int GledalacId { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public DateTime DatumSlanja { get; set; }
        [Required]
        public bool Procitana { get; set; }
    }
}
