using MultiShop.Services.Discount.DTOs.DiscountDTOs;

namespace MultiShop.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountDTO>> GetAllDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateDiscountDTO createCouponDTO);
        Task UpdateDiscountCouponAsync(UpdateDiscountDTO updateCouponDTO);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetByIdDiscountDTO> GetByIdDiscountCouponAsync(int id);
    }
}