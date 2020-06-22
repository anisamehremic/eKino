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
    public class FilmoviFilmskeLicnostiController : BaseCRUDController<Model.FilmoviFilmskeLicnosti,
        object, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest>
    {
        public FilmoviFilmskeLicnostiController(ICRUDService<FilmoviFilmskeLicnosti, object, FilmoviFilmskeLicnostiUpsertRequest, FilmoviFilmskeLicnostiUpsertRequest> service) : base(service)
        {
        }
    }
}