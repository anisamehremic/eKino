using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class FilmoviSearchRequest
    {
        public string Naziv { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public List<int> Zanrovi { get; set; }
    }
}
