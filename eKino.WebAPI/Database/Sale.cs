using System;
using System.Collections.Generic;

namespace eKino.WebAPI.Database
{
    public partial class Sale
    {
        public Sale()
        {
            Projekcije = new HashSet<Projekcije>();
            Sjedista = new HashSet<Sjedista>();
        }

        public int SalaId { get; set; }
        public string Naziv { get; set; }
        public int BrojSjedista { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }

        public virtual ICollection<Projekcije> Projekcije { get; set; }
        public virtual ICollection<Sjedista> Sjedista { get; set; }
    }
}
