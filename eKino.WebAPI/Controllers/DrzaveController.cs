using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    public class DrzaveController : BaseCRUDController<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest>
    {
        public DrzaveController(Services.ICRUDService<Model.Drzave, object, DrzaveUpsertRequest, DrzaveUpsertRequest> service) : base(service)
        {
        }
    }
}