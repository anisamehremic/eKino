using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Zanrovi
    {
        public Zanrovi()
        {
            FilmoviZanrovi = new HashSet<FilmoviZanrovi>();
            Pretplate = new HashSet<Pretplate>();
        }

        public int ZanrId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<FilmoviZanrovi> FilmoviZanrovi { get; set; }
        public virtual ICollection<Pretplate> Pretplate { get; set; }
    }
}
