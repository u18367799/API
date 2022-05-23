using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Crayon_Kids.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Class_Type> Class_Types { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee_Type> Employee_Types { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);






        }

    }

}





