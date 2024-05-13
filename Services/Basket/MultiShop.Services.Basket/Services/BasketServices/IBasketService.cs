using MultiShop.Services.Basket.DTOs;

namespace MultiShop.Services.Basket.Services.BasketServices
{
    public interface IBasketService
    {
        Task<BasketTotalDTO> GetBasket(string userID);
        Task SaveBasket(BasketTotalDTO basketTotalDTO);
        Task DeleteBasket(string userID);
    }
}