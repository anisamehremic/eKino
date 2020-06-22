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
    public class PretplateService : BaseCRUDService<Model.Pretplate, PretplateSearchRequest, Database.Pretplate,PretplateUpsertRequest, PretplateUpsertRequest>
    {
        public PretplateService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Pretplate> Get(PretplateSearchRequest search)
        {
            var query = _context.Pretplate.Include(a=>a.Gledalac).Include(a=>a.Zanr).Where(a=>a.Otkazana==false).AsQueryable();
            if (search.ZanrId != null)
            {
                query = query.Where(a => a.ZanrId == search.ZanrId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Pretplate>>(list);
        }
    }
}
