using eKino.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI
{
    public class SetupService
    {
        public static void Init(eKinoContext context)
        {
            context.Database.Migrate();
        }
    }
}
