using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Discount.DTOs.DiscountDTOs;
using MultiShop.Services.Discount.Services;

namespace MultiShop.Services.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountService.GetAllDiscountCouponAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var values = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountDTO createCouponDTO)
        {
            await _discountService.CreateDiscountCouponAsync(createCouponDTO);
            return Ok("Kupon Başarıyla Oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountDTO updateCouponDTO)
        {
            await _discountService.UpdateDiscountCouponAsync(updateCouponDTO);
            return Ok("İndirim Kuponu Başarıyla Güncellendi");
        }
    }
}