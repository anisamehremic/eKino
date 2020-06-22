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
    public class SjedistaServices : BaseCRUDService<Model.Sjedista, SjedistaSearchRequest, Database.Sjedista, SjedistaUpsertRequest, SjedistaUpsertRequest>
    {
        public SjedistaServices(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Sjedista> Get(SjedistaSearchRequest search)
        {
            var query = _context.Sjedista.Include(a=>a.Sala).AsQueryable();
            if (search.SalaId != null)
            {
                query = query.Where(a => a.SalaId == search.SalaId);
            }
            return _mapper.Map<List<Model.Sjedista>>(query);
        }
    }
}
