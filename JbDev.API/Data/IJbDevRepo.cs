﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JbDev.API.Models;

namespace JbDev.API.Data
{
    public interface IJbDevRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
