﻿using Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Authenticate
{
    public interface IHttpContext
    {
        CurrentUser CurrentUser { get; }

        public bool Exists { get; }
    }
}
