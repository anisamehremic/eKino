using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class NotifikacijeService : BaseCRUDService<Model.Notifikacije, NotifikacijeSearchRequest, Database.Notifikacije, NotifikacijeUpsertRequest, NotifikacijeUpsertRequest>
    {
        public NotifikacijeService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Notifikacije> Get(NotifikacijeSearchRequest search)
        {
            var query = _context.Notifikacije.AsQueryable();
            if (search.Procitana.HasValue)
            {
                query = query.Where(a => a.Procitana);
            }
            if (search.Neprocitana.HasValue)
            {
                query = query.Where(a => a.Procitana==false);
            }
            if (search.GledalacId.HasValue)
            {
                query = query.Where(a => a.GledalacId == search.GledalacId);
            }
            return _mapper.Map<List<Model.Notifikacije>>(query);
        }
    }
}
