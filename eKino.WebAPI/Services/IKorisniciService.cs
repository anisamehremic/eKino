using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest search);
        Model.Korisnici GetById(int Id);
        Model.Korisnici Insert(KorisniciUpsertRequest insert);
        Model.Korisnici Update(int Id, KorisniciUpsertRequest update);
    }
}
