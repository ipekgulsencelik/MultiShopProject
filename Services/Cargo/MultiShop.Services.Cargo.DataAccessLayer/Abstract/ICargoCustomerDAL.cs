using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.DataAccessLayer.Abstract
{
    public interface ICargoCustomerDAL : IGenericDAL<CargoCustomer>
    {
        CargoCustomer GetCargoCustomerByID(string id);
    }
}