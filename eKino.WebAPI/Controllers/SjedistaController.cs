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
    public class SjedistaController : BaseCRUDController<Model.Sjedista, SjedistaSearchRequest, SjedistaUpsertRequest, SjedistaUpsertRequest>
    {
        public SjedistaController(ICRUDService<Sjedista, SjedistaSearchRequest, SjedistaUpsertRequest, SjedistaUpsertRequest> service) : base(service)
        {
        }
    }
}