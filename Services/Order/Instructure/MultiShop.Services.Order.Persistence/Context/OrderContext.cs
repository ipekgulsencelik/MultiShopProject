using Microsoft.EntityFrameworkCore;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1434;initial Catalog=MultiShopOrderDB;User=sa;Password=123456aA*:integrated security=true;trusted_connection=false;encrypt=false");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}