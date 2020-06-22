using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class NovostiService : BaseCRUDService<Model.Novosti, NovostiSearchRequest, Database.Novosti, NovostiUpsertRequest, NovostiUpsertRequest>
    {
        public NovostiService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Novosti> Get(NovostiSearchRequest search)
        {
            var query = _context.Novosti.Include(a=>a.Korisnik).AsQueryable();
            if (search.Default != "")
            {
                query = _context.Novosti.Where(a => a.DatumObjave.Day == search.DatumObjave.Day &&
                a.DatumObjave.Month == search.DatumObjave.Month && a.DatumObjave.Year == search.DatumObjave.Year);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Novosti>>(query);
        }
    }
}
