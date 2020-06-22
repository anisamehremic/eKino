using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model;
using eKino.Model.Requests;
using eKino.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    public class ZanroviController : BaseCRUDController<Model.Zanrovi, object, ZanroviUpsertRequest, ZanroviUpsertRequest>
    {
        public ZanroviController(ICRUDService<Zanrovi, object, ZanroviUpsertRequest, ZanroviUpsertRequest> service) : base(service)
        {
        }
    }
}