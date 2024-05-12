using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.DTO.DTOs.CargoDetailDTOs;
using MultiShop.Services.Cargo.EntityLayer.Concrete;

namespace MultiShop.Services.Cargo.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _CargoDetailService;

        public CargoDetailsController(ICargoDetailService CargoDetailService)
        {
            _CargoDetailService = CargoDetailService;
        }

        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _CargoDetailService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoDetail(CreateCargoDetailDTO createCargoDetailDTO)
        {
            CargoDetail CargoDetail = new CargoDetail()
            {
                Barcode = createCargoDetailDTO.Barcode,
                CargoCompanyID= createCargoDetailDTO.CargoCompanyID,
                ReceiverCustomer = createCargoDetailDTO.ReceiverCustomer,
                SenderCustomer = createCargoDetailDTO.SenderCustomer
            };
            _CargoDetailService.TInsert(CargoDetail);
            return Ok("Kargo Detayları Başarıyla Oluşturuldu");
        }

        [HttpDelete]
        public IActionResult RemoveCargoDetail(int id)
        {
            _CargoDetailService.TDelete(id);
            return Ok("Kargo Detayları Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoDetailByID(int id)
        {
            var values = _CargoDetailService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDTO updateCargoDetailDTO)
        {
            CargoDetail CargoDetail = new CargoDetail()
            {
                Barcode = updateCargoDetailDTO.Barcode,
                CargoCompanyID = updateCargoDetailDTO.CargoCompanyID,
                CargoDetailID = updateCargoDetailDTO.CargoDetailID,
                ReceiverCustomer = updateCargoDetailDTO.ReceiverCustomer,
                SenderCustomer = updateCargoDetailDTO.SenderCustomer
            };
            _CargoDetailService.TUpdate(CargoDetail);
            return Ok("Kargo Detayları Başarıyla Güncellendi");
        }
    }
}