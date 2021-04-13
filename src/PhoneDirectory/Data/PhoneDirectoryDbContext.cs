using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PhoneDirectoryDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Report> Reports { get; set; }

        /// <summary>
        /// Use scafholding dotnet ef dbcontext scaffold "Host=localhost;Database=mydatabase;Username=myuser;Password=mypassword" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=mydatabase;Username=myuser;Password=mypassword");
        }
    }
}
