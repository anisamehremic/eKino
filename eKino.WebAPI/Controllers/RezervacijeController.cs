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
    public class RezervacijeController : BaseCRUDController<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeController(ICRUDService<Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest> service) : base(service)
        {
        }
    }
}