﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfacies.Services
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
