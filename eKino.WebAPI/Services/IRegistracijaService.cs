using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public interface IRegistracijaService
    {
        Model.Gledaoci Insert(GledaociUpsertRequest insert);
        List<Model.Gledaoci> Get(GledaociSearchRequest insert);
    }
}
