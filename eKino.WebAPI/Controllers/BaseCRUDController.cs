using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.WebAPI.Services;
using eProdaja.WebAPI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{

    public class BaseCRUDController<TModel, TSearch, TInsert, TUpdate> : BaseController<TModel, TSearch>
    {
        private readonly ICRUDService<TModel, TSearch, TInsert, TUpdate> _service;
        public BaseCRUDController(ICRUDService<TModel, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }
        [HttpPost]
        public TModel Insert(TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{Id}")]

        public TModel Update(int Id, TUpdate request)
        {
            return _service.Update(Id, request);
        }

    }
}