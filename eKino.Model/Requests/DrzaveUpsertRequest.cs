using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class DrzaveUpsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
