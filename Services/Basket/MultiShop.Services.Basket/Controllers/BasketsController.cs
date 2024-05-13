using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Basket.DTOs;
using MultiShop.Services.Basket.Services.BasketServices;
using MultiShop.Services.Basket.Services.LoginServices;

namespace MultiShop.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginService;

        public BasketsController(IBasketService basketService, ILoginService loginService)
        {
            _basketService = basketService;
            _loginService = loginService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasketDetail()
        {
            var user = User.Claims;
            var values = await _basketService.GetBasket(_loginService.GetUserID);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> SaveBasket(BasketTotalDTO basketTotalDTO)
        {
            basketTotalDTO.UserID = _loginService.GetUserID;
            await _basketService.SaveBasket(basketTotalDTO);
            return Ok("Sepetteki değişiklikler kaydedili");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasket(_loginService.GetUserID);
            return Ok("Sepet başarıyla silindi");
        }
    }
}