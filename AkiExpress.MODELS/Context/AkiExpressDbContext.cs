using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkiExpress.MODELS.Context
{
    public class AkiExpressDbContext : DbContext
    {
        public AkiExpressDbContext(DbContextOptions<AkiExpressDbContext> context) : base(context) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;initial catalog=AkiExpressDB;integrated security=True;MultipleActiveResultSets=True;");
            }
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
