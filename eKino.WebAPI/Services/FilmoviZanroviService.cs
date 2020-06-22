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
    public class FilmoviZanroviService : BaseCRUDService<Model.FilmoviZanrovi, FilmoviZanroviSearchRequest, Database.FilmoviZanrovi, FilmoviZanroviUpsertRequest, FilmoviZanroviUpsertRequest>
    {
        public FilmoviZanroviService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.FilmoviZanrovi> Get(FilmoviZanroviSearchRequest search)
        {
            var query = _context.FilmoviZanrovi.AsQueryable();
            if (search.FilmId != null)
            {
                query = query.Where(a => a.FilmId == search.FilmId);
            }
            return _mapper.Map<List<Model.FilmoviZanrovi>>(query);
        }
    }
}
