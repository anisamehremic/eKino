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
    public class FilmskeUlogeController : BaseCRUDController<Model.FilmskeUloge, object, FilmskeUlogeUpsertRequest, FilmskeUlogeUpsertRequest>
    {
        public FilmskeUlogeController(ICRUDService<FilmskeUloge, object, FilmskeUlogeUpsertRequest, FilmskeUlogeUpsertRequest> service) : base(service)
        {
        }
    }
}