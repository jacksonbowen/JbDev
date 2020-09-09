using JbDev.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JbDev.API.Contexts
{
    public class JbDevContext : DbContext
    {
        public JbDevContext(DbContextOptions<JbDevContext> opt) : base(opt)
        {

        }
        //TODO
        //map other models here

        public DbSet<Command> Commands { get; set; }
    }
}


