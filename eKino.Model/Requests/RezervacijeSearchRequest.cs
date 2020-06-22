using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class RezervacijeSearchRequest
    {
        public DateTime? DatumRezervacije { get; set; }
        public string Username { get; set; }
    }
}
