using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class RezervacijeUpsertRequest
    {
        [Required]
        public int ProjekcijaId { get; set; }
        public int?GledalacId { get; set; }
        [Required]
        public DateTime DatumRezervacije { get; set; }
        [Required]
        public int BrojKarata { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public bool Status { get; set; }
        public bool mobilna { get; set; }=false;

        public List<UlazniceUpsertRequest> requestsUlaznice{ get;set; }


    }
}
