using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public  class UlazniceUpsertRequest
    {
        public int? RezervacijaId { get; set; }
        public int? GledalacId { get; set; }
        [Required]
        public int ProjekcijaId { get; set; }
        public byte[] Qrcode { get; set; }
        [Required]
        public int SjedisteId { get; set; }
        public decimal Cijena { get; set; }
        [Required]
        public bool Status { get; set; }
        public string QRtekst { get; set; }
        public string CijenaString { get; set; }
    }
}
