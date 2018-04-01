using CafeApplication.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            new ConsommateurMap(modelBuilder.Entity<Consommateur>().SeedData(

                new Consommateur { Id = 1, Nom = "Cousineau", Prenom = "Carl" },
            new Consommateur { Id = 2, Nom = "BelleVille", Prenom = " Suzanne" })

            );
            new ConsommationMap(modelBuilder.Entity<Consommation>());
        }
    }
}
