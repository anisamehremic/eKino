﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.WebAPI.Exceptions
{
    public class UserException:Exception
    {
        public UserException(string message) : base(message)
        {

        }
    }
}
