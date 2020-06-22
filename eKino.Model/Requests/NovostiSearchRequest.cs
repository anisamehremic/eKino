using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class NovostiSearchRequest
    {
        public DateTime DatumObjave { get; set; }
        public string Default { get; set; } = "";
    }
}
