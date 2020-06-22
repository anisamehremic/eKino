using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eKino.Model.Requests;
using eKino.Model;
using eKino.WebAPI.Services;

namespace eKino.WebAPI.Controllers
{
    public class NovostiController : BaseCRUDController<Model.Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest>
    {
        public NovostiController(ICRUDService<Novosti, NovostiSearchRequest, NovostiUpsertRequest, NovostiUpsertRequest> service) : base(service)
        {
        }
    }
}