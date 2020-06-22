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
    public class ProjekcijeController : BaseCRUDController<Model.Projekcije, ProjekcijeSearchRequest, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest>
    {
        public ProjekcijeController(ICRUDService<Projekcije, ProjekcijeSearchRequest, ProjekcijeUpsertRequest, ProjekcijeUpsertRequest> service) : base(service)
        {
        }
    }
}