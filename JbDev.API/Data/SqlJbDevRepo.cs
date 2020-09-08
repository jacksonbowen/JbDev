using JbDev.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JbDev.API.Data
{
    public class SqlJbDevRepo : IJbDevRepo
    {
        private readonly JbDevContext _context;

        public SqlJbDevRepo(JbDevContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p =>p.Id == id);
        }
    }
}
