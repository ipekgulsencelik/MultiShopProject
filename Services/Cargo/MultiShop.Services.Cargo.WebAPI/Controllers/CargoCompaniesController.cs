using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DTO.DTOs.CargoCompanyDTOs;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _cargoCompanyService;

        public CargoCompaniesController(ICargoCompanyService cargoCompanyService)
        {
            _cargoCompanyService = cargoCompanyService;
        }

        [HttpGet]
        public IActionResult CargoCompanyList()
        {
            var values = _cargoCompanyService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoCompany(CreateCargoCompanyDTO createCargoCompanyDTO)
        {
            CargoCompany cargoCompany = new CargoCompany()
            {
                CargoCompanyName = createCargoCompanyDTO.CargoCompanyName
            };
            _cargoCompanyService.TInsert(cargoCompany);
            return Ok("Kargo Şirketi Başarıyla Oluşturuldu");
        }

        [HttpDelete]
        public IActionResult RemoveCargoCompany(int id)
        {
            _cargoCompanyService.TDelete(id);
            return Ok("Kargo Şirketi Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoCompanyByID(int id)
        {
            var values = _cargoCompanyService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCargoCompany(UpdateCargoCompanyDTO updateCargoCompanyDTO)
        {
            CargoCompany cargoCompany = new CargoCompany()
            {
                CargoCompanyID = updateCargoCompanyDTO.CargoCompanyID,
                CargoCompanyName = updateCargoCompanyDTO.CargoCompanyName
            };
            _cargoCompanyService.TUpdate(cargoCompany);
            return Ok("Kargo Şirketi Başarıyla Güncellendi");
        }
    }
}