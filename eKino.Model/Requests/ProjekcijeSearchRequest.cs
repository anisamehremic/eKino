using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class ProjekcijeSearchRequest
    {
        public int? SalaId { get; set; }
        public int? FilmId { get; set; }
        public DateTime? DatumPrikazivanja { get; set; }
    }
}
