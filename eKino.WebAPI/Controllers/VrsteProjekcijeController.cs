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
    public class VrsteProjekcijeController : BaseCRUDController<Model.VrsteProjekcije, object, VrsteProjekcijeUpsertRequest, VrsteProjekcijeUpsertRequest>
    {
        public VrsteProjekcijeController(ICRUDService<VrsteProjekcije, object, VrsteProjekcijeUpsertRequest, VrsteProjekcijeUpsertRequest> service) : base(service)
        {
        }
    }
}