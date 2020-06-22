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
    public class FilmskeLicnostiService : BaseCRUDService<Model.FilmskeLicnosti, FilmskeLicnostiSearchRequest, Database.FilmskeLicnosti, FilmskeLicnostiUpsertRequest, FilmskeLicnostiUpsertRequest>
    {
        public FilmskeLicnostiService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.FilmskeLicnosti> Get(FilmskeLicnostiSearchRequest search)
        {
            var query = _context.FilmskeLicnosti.Include(x=>x.Drzava).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(a => a.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(a => a.Prezime.StartsWith(search.Prezime));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.FilmskeLicnosti>>(list);
        }
    }
}
