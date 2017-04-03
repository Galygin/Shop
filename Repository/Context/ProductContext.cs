using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Models;

namespace Repository.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("ApplicationServices")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Recall> Recalls { get; set; }
    }
}
