using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.Repository;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EFCargoDetailDAL : GenericRepository<CargoDetail>, ICargoDetailDAL
    {
        public EFCargoDetailDAL(CargoContext context) : base(context)
        {
        }
    }
}