using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.EntityFramework;
using MultiShop.Services.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Services.Cargo.BusinessLayer.Concrete
{
    public class CargoCustomerManager : ICargoCustomerService
    {
        private readonly ICargoCustomerDAL _cargoCustomerDAL;

        public CargoCustomerManager(ICargoCustomerDAL cargoCustomerDAL)
        {
            _cargoCustomerDAL = cargoCustomerDAL;
        }

        public void TDelete(int id)
        {
            _cargoCustomerDAL.Delete(id);
        }

        public List<CargoCustomer> TGetAll()
        {
            return _cargoCustomerDAL.GetAll();
        }

        public CargoCustomer TGetByID(int id)
        {
            return _cargoCustomerDAL.GetByID(id);
        }

        public CargoCustomer TGetCargoCustomerByID(string id)
        {
            return _cargoCustomerDAL.GetCargoCustomerByID(id);
        }

        public void TInsert(CargoCustomer entity)
        {
            _cargoCustomerDAL.Insert(entity);
        }

        public void TUpdate(CargoCustomer entity)
        {
            _cargoCustomerDAL.Update(entity);
        }
    }
}