namespace MultiShop.Services.Catalog.DTOs.CategoryDTOs
{
    public class ResultCategoryDTO
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
        public bool IsHome { get; set; }
        public bool IsDeleted { get; set; }
    }
}