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
    public class OcjeneService : BaseCRUDService<Model.Ocjene, OcjeneSearchRequest, Database.Ocjene, OcjeneUpsertRequest, OcjeneUpsertRequest>
    {
        public OcjeneService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _context.Ocjene.Include(a => a.Gledalac).Include(b => b.Film).AsQueryable();
            if (search.FilmId != null)
            {
                query = query.Where(a => a.FilmId == search.FilmId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Ocjene>>(list);
        }
    }
}
