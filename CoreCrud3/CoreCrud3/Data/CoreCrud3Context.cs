using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreCrud3.Models;

namespace CoreCrud3.Models
{
    public class CoreCrud3Context : DbContext
    {
        public CoreCrud3Context (DbContextOptions<CoreCrud3Context> options)
            : base(options)
        {
        }

        public DbSet<CoreCrud3.Models.HockeyTeam> HockeyTeam { get; set; }

        public DbSet<CoreCrud3.Models.Nationality> Nationality { get; set; }
    }
}
