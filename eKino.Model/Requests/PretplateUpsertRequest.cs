using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class PretplateUpsertRequest
    {
        [Required]
        public int ZanrId { get; set; }
        [Required]
        public int GledalacId { get; set; }
        [Required]
        public DateTime DatumPretplate { get; set; }
        [Required]
        public bool Otkazana { get; set; }
    }
}
