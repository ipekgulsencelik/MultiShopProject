using Microsoft.EntityFrameworkCore;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.Concrete
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MultiShopCargoDB;User Id=sa;Password=123456aA*;Integrated Security=false;Trusted_Connection=false;Encrypt=false;");
        }

        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoCustomer> CargoCustomers { get; set; }
        public DbSet<CargoOperation> CargoOperations { get; set; }
    }
}