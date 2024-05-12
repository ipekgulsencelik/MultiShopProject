using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.BusinessLayer.Abstract
{
    public interface ICargoCustomerService : IGenericService<CargoCustomer>
    {
        CargoCustomer TGetCargoCustomerByID(string id);
    }
}