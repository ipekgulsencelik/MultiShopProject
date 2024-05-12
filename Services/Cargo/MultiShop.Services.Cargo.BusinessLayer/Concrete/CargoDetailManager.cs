using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDAL _cargoDetailDAL;

        public CargoDetailManager(ICargoDetailDAL cargoDetailDAL)
        {
            _cargoDetailDAL = cargoDetailDAL;
        }

        public void TDelete(int id)
        {
            _cargoDetailDAL.Delete(id);
        }

        public List<CargoDetail> TGetAll()
        {
            return _cargoDetailDAL.GetAll();
        }

        public CargoDetail TGetByID(int id)
        {
            return _cargoDetailDAL.GetByID(id);
        }

        public void TInsert(CargoDetail entity)
        {
            _cargoDetailDAL.Insert(entity);
        }

        public void TUpdate(CargoDetail entity)
        {
            _cargoDetailDAL.Update(entity);
        }
    }
}