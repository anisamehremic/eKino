using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model
{
    public class KorisnickeUloge
    {
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public Uloge Uloga { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}
