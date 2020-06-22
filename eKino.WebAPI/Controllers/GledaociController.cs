using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model;
using eKino.Model.Requests;
using eKino.WebAPI.Services;
using eProdaja.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    public class GledaociController : BaseCRUDController<Model.Gledaoci, GledaociSearchRequest, GledaociUpsertRequest, GledaociUpsertRequest>
    {
        public GledaociController(ICRUDService<Gledaoci, GledaociSearchRequest, GledaociUpsertRequest, GledaociUpsertRequest> service) : base(service)
        {
        }
    }
}