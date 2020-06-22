using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class ProjekcijeUpsertRequest
    {
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int SalaId { get; set; }
        [Required]
        public DateTime DatumVrijemeOdrzavanja { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public int VrstaProjekcijeId { get; set; }
    }
}
