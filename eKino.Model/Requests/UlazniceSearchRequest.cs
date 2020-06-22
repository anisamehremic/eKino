using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class UlazniceSearchRequest
    {
        public int? ProjekcijaId { get; set; }
        public int? GledalacId { get; set; }
        public int? RezervacijaId { get; set; }
        public bool? Aktivne { get; set; }
        public bool? Neaktivne { get; set; }
       
    }
}
