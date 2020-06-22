using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class NotifikacijeSearchRequest
    {
        public bool? Procitana { get; set; }
        public bool? Neprocitana { get; set; }
        public int? GledalacId { get; set; }
    }
}
