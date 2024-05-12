using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.Repository;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.EntityFramework
{
    public class EFCargoCustomerDAL : GenericRepository<CargoCustomer>, ICargoCustomerDAL
    {
        private readonly CargoContext _cargoContext;

        public EFCargoCustomerDAL(CargoContext context, CargoContext cargoContext) : base(context)
        {
            _cargoContext = cargoContext;
        }

        public CargoCustomer GetCargoCustomerByID(string id)
        {
            var values = _cargoContext.CargoCustomers.Where(x => x.UserCustomerID == id).FirstOrDefault();
            return values;
        }
    }
}