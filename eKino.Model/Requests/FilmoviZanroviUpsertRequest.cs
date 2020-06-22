using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKino.Model.Requests
{
    public class FilmoviZanroviUpsertRequest
    {
        [Required]
        public int FilmId { get; set; }
        [Required]
        public int ZanrId { get; set; }
    }
}
