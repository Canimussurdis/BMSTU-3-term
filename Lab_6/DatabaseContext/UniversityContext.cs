using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DatabaseContext
{
    public class UniversityContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Curator> Curators { get; set; }

        public UniversityContext()
        {
        }

        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=GCTP_2213.00;Server=localhost;Port=5432;Database=university-database;");
        }
    }
}
