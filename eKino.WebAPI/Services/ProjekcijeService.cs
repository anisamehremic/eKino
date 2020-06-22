using AutoMapper;
using eKino.Model.Requests;
using eKino.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class ProjekcijeService : BaseCRUDService<Model.Projekcije, ProjekcijeSearchRequest, Database.Projekcije, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest>
    {
        public ProjekcijeService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Projekcije> Get(ProjekcijeSearchRequest search)
        {
            var query = _context.Projekcije.Include(x=>x.Film).Include(a=>a.Film.Drzava).Include(x=>x.Sala).Include(x=>x.VrstaProjekcije).AsQueryable();
            if (search.FilmId.HasValue && search.FilmId != 0)
            {
                query = query.Where(a => a.FilmId == search.FilmId);
            }
            if (search.SalaId.HasValue && search.SalaId != 0)
            {
                query = query.Where(a => a.SalaId == search.SalaId);
            }
            if (search.DatumPrikazivanja.HasValue)
            {
                query = query.Where(a => a.DatumVrijemeOdrzavanja.Day == search.DatumPrikazivanja.Value.Day && a.DatumVrijemeOdrzavanja.Month == search.DatumPrikazivanja.Value.Month
                    && a.DatumVrijemeOdrzavanja.Year == search.DatumPrikazivanja.Value.Year);
            }
            var list = query.ToList();

            return _mapper.Map<List<Model.Projekcije>>(list);
        }

        public override Model.Projekcije GetById(int Id)
        {
            var item = _context.Projekcije.Include(x => x.Film).Include(x => x.Sala).Include(x => x.VrstaProjekcije).Where(x=>x.ProjekcijaId == Id).FirstOrDefault();
            return _mapper.Map<Model.Projekcije>(item);
        }


    }
}
