using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class SjedistaUpsertRequest
    {
        public string Opis { get; set; }
        [Required]
        public int SalaId { get; set; }
        [Required]
        public string Red { get; set; }
        [Required]
        public string Kolona { get; set; }
        [Required]
        public bool Zauzeto { get; set; }
    }
}
