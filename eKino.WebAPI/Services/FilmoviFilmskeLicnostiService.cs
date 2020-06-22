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
    public class FilmoviFilmskeLicnostiService : BaseCRUDService<Model.FilmoviFilmskeLicnosti, object,
        Database.FilmoviFilmskeLicnosti, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest>
    {
        public FilmoviFilmskeLicnostiService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.FilmoviFilmskeLicnosti> Get(object search)
        {
            var query = _context.FilmoviFilmskeLicnosti.Include(a=>a.Film).Include(a=>a.FilmskaLicnost)
                .Include(a=>a.FilmskaUloga).AsQueryable();
            return _mapper.Map<List<Model.FilmoviFilmskeLicnosti>>(query);
        }
    }
}
