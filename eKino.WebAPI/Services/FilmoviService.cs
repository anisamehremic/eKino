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
    public class FilmoviService : BaseCRUDService<Model.Filmovi, FilmoviSearchRequest, Database.Filmovi, FilmoviUpsertRequest, FilmoviUpsertRequest>
    {
        public FilmoviService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Filmovi> Get(FilmoviSearchRequest search)
        {
            var query = _context.Filmovi.Include(x => x.Drzava).Include(a => a.FilmoviZanrovi).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(a => a.Naziv.StartsWith(search.Naziv));
            }
            if(search.DatumIzdavanja.HasValue)
            {
                query = query.Where(a => a.DatumSnimanja.Day == search.DatumIzdavanja.Value.Day && a.DatumSnimanja.Month == search.DatumIzdavanja.Value.Month
                    && a.DatumSnimanja.Year == search.DatumIzdavanja.Value.Year);
            }
            
            var list = query.ToList();

            if (search.Zanrovi != null)
            {
                var list2 = new List<Database.Filmovi>();

                foreach (var item in search.Zanrovi)
                {
                    var fm = _context.FilmoviZanrovi.Include(a=>a.Film).Where(a => a.ZanrId == item).ToList();
                    foreach (var item2 in fm)
                    {
                        if (!list2.Contains(item2.Film)){
                            if (list.Contains(item2.Film))
                            {
                                list2.Add(item2.Film);
                            }
                        }
                    }
                }
                return _mapper.Map<List<Model.Filmovi>>(list2);
            }
         
            return _mapper.Map<List<Model.Filmovi>>(list);
        }
        public override Model.Filmovi Insert(FilmoviUpsertRequest request)
        {
            var zanrovi = request.Zanrovi;
            var obj = _mapper.Map<Database.Filmovi>(request);
            _context.Filmovi.Add(obj);
            _context.SaveChanges();

            foreach (var item in zanrovi)
            {
                Database.FilmoviZanrovi novi = new Database.FilmoviZanrovi()
                {
                    FilmId = obj.FilmId,
                    ZanrId = item
                };
                _context.FilmoviZanrovi.Add(novi);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Filmovi>(obj);

        }

        public override Model.Filmovi Update(int Id, FilmoviUpsertRequest request)
        {
            var obj = _context.Filmovi.Find(Id);
            _mapper.Map(request, obj);
            var zanroviBrisanje = _context.FilmoviZanrovi.ToList();
            foreach (var item in zanroviBrisanje)
            {
                if (item.FilmId == obj.FilmId)
                    _context.Remove(item);
            }
            _context.SaveChanges();
            foreach (var item in request.Zanrovi)
            {
                FilmoviZanrovi novi = new FilmoviZanrovi()
                {
                    FilmId = obj.FilmId,
                    ZanrId = item,
                };
                _context.FilmoviZanrovi.Add(novi);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Filmovi>(obj);

        }
    }
}
