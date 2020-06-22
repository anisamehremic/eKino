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
    public class PretplateController : BaseCRUDController<Model.Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest>
    {
        public PretplateController(ICRUDService<Pretplate, PretplateSearchRequest, PretplateUpsertRequest, PretplateUpsertRequest> service) : base(service)
        {
        }
    }
}