﻿using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Novosti
    {
        public Novosti()
        {
            Notifikacije = new HashSet<Notifikacije>();
        }

        public int NovostId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual ICollection<Notifikacije> Notifikacije { get; set; }
    }
}
