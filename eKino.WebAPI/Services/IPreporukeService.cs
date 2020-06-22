using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public interface IPreporukeService
    {
        List<Model.Projekcije> Get(int GledalacId);
    }
}
