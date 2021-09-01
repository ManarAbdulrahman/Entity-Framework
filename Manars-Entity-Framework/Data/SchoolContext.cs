using Manars_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manars_Entity_Framework.Data
{
    public class SchoolContext : DbContext
    {


        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollmens { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");

            modelBuilder.Entity<Enrollment>().ToTable("Student");


        }
    }
}
