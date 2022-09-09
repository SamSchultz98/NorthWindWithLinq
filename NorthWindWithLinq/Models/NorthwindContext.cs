using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWithLinq.Models
{
    public class NorthwindContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public NorthwindContext()        {   }       //The constructor that doesn't do anything. Only needed for console apps
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = @"server=localhost\sqlexpress;" + "database=Northwind;" + "trusted_connection=true;";
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
       
        }
    }
}
