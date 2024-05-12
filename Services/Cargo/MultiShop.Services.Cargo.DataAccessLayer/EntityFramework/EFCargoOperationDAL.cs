using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.Repository;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EFCargoOperationDAL : GenericRepository<CargoOperation>, ICargoOperationDAL
    {
        public EFCargoOperationDAL(CargoContext context) : base(context)
        {
        }
    }
}