using MultiShop.Services.Basket.DTOs;
using MultiShop.Services.Basket.Settings;
using System.Text.Json;

namespace MultiShop.Services.Basket.Services.BasketServices
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task DeleteBasket(string userID)
        {
            await _redisService.GetDb().KeyDeleteAsync(userID);
        }

        public async Task<BasketTotalDTO> GetBasket(string userID)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(userID);
            return JsonSerializer.Deserialize<BasketTotalDTO>(existBasket);
        }

        public async Task SaveBasket(BasketTotalDTO basketTotalDTO)
        {
            await _redisService.GetDb().StringSetAsync(basketTotalDTO.UserID, JsonSerializer.Serialize(basketTotalDTO));
        }
    }
}