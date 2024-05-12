using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DTO.DTOs.CargoOperationDTOs;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _CargoOperationService;

        public CargoOperationsController(ICargoOperationService CargoOperationService)
        {
            _CargoOperationService = CargoOperationService;
        }

        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _CargoOperationService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoOperation(CreateCargoOperationDTO createCargoOperationDTO)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
                Barcode = createCargoOperationDTO.Barcode,
                Description = createCargoOperationDTO.Description,
                OperationDate = createCargoOperationDTO.OperationDate
            };
            _CargoOperationService.TInsert(CargoOperation);
            return Ok("Kargo İşlemi Başarıyla Oluşturuldu");
        }

        [HttpDelete]
        public IActionResult RemoveCargoOperation(int id)
        {
            _CargoOperationService.TDelete(id);
            return Ok("Kargo İşlemi Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoOperationByID(int id)
        {
            var values = _CargoOperationService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCargoOperation(UpdateCargoOperationDTO updateCargoOperationDTO)
        {
            CargoOperation CargoOperation = new CargoOperation()
            {
                Barcode = updateCargoOperationDTO.Barcode,
                CargoOperationID = updateCargoOperationDTO.CargoOperationID,
                Description = updateCargoOperationDTO.Description,
                OperationDate = updateCargoOperationDTO.OperationDate
            };
            _CargoOperationService.TUpdate(CargoOperation);
            return Ok("Kargo İşlemi Başarıyla Güncellendi");
        }
    }
}