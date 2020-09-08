using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JbDev.API.Models;

namespace JbDev.API.Data
{
    public interface IJbDevRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
