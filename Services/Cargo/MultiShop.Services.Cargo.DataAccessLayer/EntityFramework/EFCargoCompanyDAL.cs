using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.Repository;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EFCargoCompanyDAL : GenericRepository<CargoCompany>, ICargoCompanyDAL
    {
        public EFCargoCompanyDAL(CargoContext context) : base(context)
        {
        }
    }
}