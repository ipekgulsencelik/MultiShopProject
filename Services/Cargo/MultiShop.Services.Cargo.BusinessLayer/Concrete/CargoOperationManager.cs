using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoOperationManager : ICargoOperationService
    {
        private readonly ICargoOperationDAL _cargoOperationDAL;

        public CargoOperationManager(ICargoOperationDAL cargoOperationDAL)
        {
            _cargoOperationDAL = cargoOperationDAL;
        }

        public void TDelete(int id)
        {
            _cargoOperationDAL.Delete(id);
        }

        public List<CargoOperation> TGetAll()
        {
            return _cargoOperationDAL.GetAll();
        }

        public CargoOperation TGetByID(int id)
        {
            return _cargoOperationDAL.GetByID(id);
        }

        public void TInsert(CargoOperation entity)
        {
            _cargoOperationDAL.Insert(entity);
        }

        public void TUpdate(CargoOperation entity)
        {
            _cargoOperationDAL.Update(entity);
        }
    }
}