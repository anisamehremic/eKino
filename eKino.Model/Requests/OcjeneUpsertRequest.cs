using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class OcjeneUpsertRequest
    {
        [Required]
        public int GledalacId { get; set; }
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int Ocjena { get; set; }
        [Required]
        public DateTime DatumOcjenjivanja { get; set; }

    }
}
