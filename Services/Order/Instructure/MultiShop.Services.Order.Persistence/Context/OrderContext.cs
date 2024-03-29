using Microsoft.EntityFrameworkCore;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;initial Catalog=MultiShopOrderDB;integrated Security=true;TrustServerCertificate=True;");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}