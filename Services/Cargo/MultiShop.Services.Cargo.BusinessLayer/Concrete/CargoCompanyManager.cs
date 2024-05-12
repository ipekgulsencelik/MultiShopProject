using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoCompanyManager : ICargoCompanyService
    {
        private readonly ICargoCompanyDAL _cargoCompanyDAL;

        public CargoCompanyManager(ICargoCompanyDAL cargoCompanyDAL)
        {
            _cargoCompanyDAL = cargoCompanyDAL;
        }
        
        public void TDelete(int id)
        {
            _cargoCompanyDAL.Delete(id);
        }

        public List<CargoCompany> TGetAll()
        {
            return _cargoCompanyDAL.GetAll();
        }
        
        public CargoCompany TGetByID(int id)
        {
            return _cargoCompanyDAL.GetByID(id);
        }
        
        public void TInsert(CargoCompany entity)
        {
            _cargoCompanyDAL.Insert(entity);
        }

        public void TUpdate(CargoCompany entity)
        {
            _cargoCompanyDAL.Update(entity);
        }
    }
}