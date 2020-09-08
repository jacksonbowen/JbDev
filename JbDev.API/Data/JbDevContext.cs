using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JbDev.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JbDev.API.Data
{
    public class JbDevContext : DbContext
    {
        public JbDevContext(DbContextOptions<JbDevContext> opt) : base(opt)
        {

        }
        //map other models here
        public DbSet<Command> Commands { get; set; }
    }
}


