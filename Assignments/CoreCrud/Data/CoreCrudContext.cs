using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreCrud.Models;

namespace CoreCrud.Models
{
    public class CoreCrudContext : DbContext
    {
        public CoreCrudContext(DbContextOptions<CoreCrudContext> options)
            : base(options)
        {
        }

        public DbSet<CoreCrud.Models.HockeyTeam> HockeyTeam { get; set; }

        public DbSet<CoreCrud.Models.Nationality> Nationality { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Initialize();
        }
    }
}