using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class NovostiUpsertRequest
    {
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Sadrzaj { get; set; }
        [Required]
        public DateTime DatumObjave { get; set; }
        [Required]
        public int KorisnikId { get; set; }

    }
}
