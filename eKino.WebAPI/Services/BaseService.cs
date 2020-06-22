using AutoMapper;
using eKino.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase : class
    {
        protected readonly eKinoContext _context;
        protected readonly IMapper _mapper;

        public BaseService(eKinoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int Id)
        {
            var obj = _context.Set<TDatabase>().Find(Id);
            return _mapper.Map<TModel>(obj);
        }
    }
}
