using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            KorisnickeUloge = new HashSet<KorisnickeUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisnickeUloge> KorisnickeUloge { get; set; }
    }
}
