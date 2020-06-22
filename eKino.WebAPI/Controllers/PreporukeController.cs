using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model;
using eKino.Model.Requests;
using eKino.WebAPI.Services;
using eProdaja.WebAPI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace eKino.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController
    {
        private readonly IPreporukeService _service;
        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Projekcije> Get(int GledalacId)
        {
            return _service.Get(GledalacId);
        }

    }
}