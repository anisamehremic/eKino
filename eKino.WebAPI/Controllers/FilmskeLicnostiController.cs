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
    public class FilmskeLicnostiController : BaseCRUDController<Model.FilmskeLicnosti, FilmskeLicnostiSearchRequest, FilmskeLicnostiUpsertRequest, FilmskeLicnostiUpsertRequest>
    {
        public FilmskeLicnostiController(ICRUDService<FilmskeLicnosti, FilmskeLicnostiSearchRequest, FilmskeLicnostiUpsertRequest, FilmskeLicnostiUpsertRequest> service) : base(service)
        {
        }
    }
}