using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eKino.Model.Requests;
using eKino.WebAPI.Services;
using eKino.Model;

namespace eKino.WebAPI.Controllers
{

    public class FilmoviZanroviController : BaseCRUDController<Model.FilmoviZanrovi, FilmoviZanroviSearchRequest, FilmoviZanroviUpsertRequest, FilmoviZanroviUpsertRequest>
    {
        public FilmoviZanroviController(ICRUDService<FilmoviZanrovi, FilmoviZanroviSearchRequest, FilmoviZanroviUpsertRequest, FilmoviZanroviUpsertRequest> service) : base(service)
        {
        }
    }
}