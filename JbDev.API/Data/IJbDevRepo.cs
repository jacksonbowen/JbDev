using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JbDev.API.Models;

namespace JbDev.API.Data
{
    public interface IJbDevRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);

    }
}
