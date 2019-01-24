using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using GlutenFreeVictuals.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GlutenFreeVictuals.Repositories
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public virtual DbSet<User> User { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
       
        public DbSet<Rating> Ratings { get; set; }
    }
}
