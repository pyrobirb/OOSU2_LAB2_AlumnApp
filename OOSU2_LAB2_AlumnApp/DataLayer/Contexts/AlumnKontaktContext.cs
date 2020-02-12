using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Models;

namespace DataLayer.Contexts
{
    public class AlumnKontaktContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OOSU2Lab2TestProject;Trusted_Connection=True; Integrated Security=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Alumn> Alumner { get; set; }
        public DbSet<Program> Programs { get; set; }


    }
}
