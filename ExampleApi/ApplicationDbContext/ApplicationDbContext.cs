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
        public DbSet<Student> Students { get; set; }
        public DbSet<AddressStudent> Address { get; set; }
        public DbSet<InstitutionStudent> Institutions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
