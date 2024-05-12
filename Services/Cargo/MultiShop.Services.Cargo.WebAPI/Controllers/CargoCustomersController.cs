using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DTO.DTOs.CargoCustomerDTOs;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;

        public CargoCustomersController(ICargoCustomerService cargoCustomerService)
        {
            _cargoCustomerService = cargoCustomerService;
        }

        [HttpGet]
        public IActionResult CargoCustomerList()
        {
            var values = _cargoCustomerService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoCustomerByID(int id)
        {
            var value = _cargoCustomerService.TGetByID(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCargoCustomer(CreateCargoCustomerDTO createCargoCustomerDTO)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Address = createCargoCustomerDTO.Address,
                City = createCargoCustomerDTO.City,
                District = createCargoCustomerDTO.District,
                Email = createCargoCustomerDTO.Email,
                Name = createCargoCustomerDTO.Name,
                Phone = createCargoCustomerDTO.Phone,
                Surname = createCargoCustomerDTO.Surname,
                UserCustomerID = createCargoCustomerDTO.UserCustomerID
            };
            _cargoCustomerService.TInsert(cargoCustomer);
            return Ok("Kargo Müşteri Ekleme İşlemi Başarıyla Yapıldı");
        }

        [HttpDelete]
        public IActionResult RemoveCargoCustomer(int id)
        {
            _cargoCustomerService.TDelete(id);
            return Ok("Kargo Müşteri Silme İşlemi Başarıyla Yapıldı");
        }

        [HttpPut]
        public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDTO updateCargoCustomerDTO)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Address = updateCargoCustomerDTO.Address,
                CargoCustomerID = updateCargoCustomerDTO.CargoCustomerID,
                City = updateCargoCustomerDTO.City,
                District = updateCargoCustomerDTO.District,
                Email = updateCargoCustomerDTO.Email,
                Name = updateCargoCustomerDTO.Name,
                Phone = updateCargoCustomerDTO.Phone,
                Surname = updateCargoCustomerDTO.Surname,
                UserCustomerID = updateCargoCustomerDTO.UserCustomerID
            };
            _cargoCustomerService.TUpdate(cargoCustomer);
            return Ok("Kargo Müşteri Güncelleme İşlemi Başarıyla Yapıldı");
        }

        [HttpGet("GetCargoCustomerByID")]
        public IActionResult GetCargoCustomerByID(string id)
        {
            return Ok(_cargoCustomerService.TGetCargoCustomerByID(id));
        }
    }
}