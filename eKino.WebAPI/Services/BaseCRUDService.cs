using AutoMapper;
using eKino.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(eKinoContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var obj = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(obj);
            _context.SaveChanges();
            return _mapper.Map<TModel>(obj);
        }

        public virtual TModel Update(int Id, TUpdate request)
        {
            var obj = _context.Set<TDatabase>().Find(Id);
            _mapper.Map(request, obj);
            _context.SaveChanges();
            return _mapper.Map<TModel>(obj);
        }
    }
}
