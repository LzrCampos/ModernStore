using MordenStore.Domain.Entities;
using System;
using System.Data.Entity;

namespace ModernStore.Infrastructure.Contexts
{
    public class ModernStoreDataContext : DbContext
    {
        public ModernStoreDataContext() : base(@"Server=.\SQLEXPRESS; Database=ModernStore; User Id=lazaro; password= 5289")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
