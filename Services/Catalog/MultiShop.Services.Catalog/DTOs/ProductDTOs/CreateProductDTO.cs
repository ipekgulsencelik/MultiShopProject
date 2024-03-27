﻿namespace MultiShop.Services.Catalog.DTOs.ProductDTOs
{
    public class CreateProductDTO
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageURL { get; set; }
        public string ProductDescription { get; set; }
        public bool IsDeleted { get; set; }
        public string CategoryID { get; set; }
    }
}