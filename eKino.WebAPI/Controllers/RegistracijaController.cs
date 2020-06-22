using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;
using eKino.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistracijaController : ControllerBase
    {
        private readonly IRegistracijaService _service;
        public RegistracijaController(IRegistracijaService service)
        {
            _service = service;
        }
        [HttpPost]
        public Model.Gledaoci Insert(GledaociUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpGet]
        public List<Model.Gledaoci> Get([FromQuery]GledaociSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}