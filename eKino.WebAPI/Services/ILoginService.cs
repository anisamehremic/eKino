using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Services
{
    public interface ILoginService
    {
        Model.Korisnici Authenticiraj(string username, string pass);
        Model.Korisnici AuthenticirajGledaoca(string username, string pass);
    }
}
