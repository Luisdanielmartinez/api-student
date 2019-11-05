using ExampleApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.ApplicationDbContext
{
    public class ApplicationDbContext :DbContext
    {
        //llaves compuesta
        //aqui usamos el api fluente que es para decir que tenemos una primary key and foreang key in the same table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TeacherStudent>().HasKey(x => new { x.TeacherOfStudentId, x.StudentId });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<AddressStudent> Address { get; set; }
        public DbSet<InstitutionStudent> Institutions { get; set; }
        public DbSet<TeacherOfStudent> Teachers { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
