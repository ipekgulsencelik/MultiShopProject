namespace MultiShop.Services.Discount.DTOs.DiscountDTOs
{
    public class CreateDiscountDTO
    {
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public DateTime ValidDate { get; set; }
    }
}