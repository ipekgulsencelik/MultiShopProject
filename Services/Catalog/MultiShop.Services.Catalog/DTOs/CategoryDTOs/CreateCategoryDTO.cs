namespace MultiShop.Services.Catalog.DTOs.CategoryDTOs
{
    public class CreateCategoryDTO
    {
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public bool IsHome { get; set; }
        public bool IsDeleted { get; set; }
    }
}