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
    public class UlazniceController : BaseCRUDController<Model.Ulaznice, UlazniceSearchRequest, UlazniceUpsertRequest, UlazniceUpsertRequest>
    {
        public UlazniceController(ICRUDService<Ulaznice, UlazniceSearchRequest, UlazniceUpsertRequest, UlazniceUpsertRequest> service) : base(service)
        {
        }
    }
}