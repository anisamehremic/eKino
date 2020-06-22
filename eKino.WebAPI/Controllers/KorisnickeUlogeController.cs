using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eKino.WebAPI.Controllers
{
    public class KorisnickeUlogeController : BaseController<Model.KorisnickeUloge, object>
    {
        public KorisnickeUlogeController(Services.IService<Model.KorisnickeUloge, object> service) : base(service)
        {
        }
    }
}