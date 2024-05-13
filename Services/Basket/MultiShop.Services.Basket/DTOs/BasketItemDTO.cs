﻿namespace MultiShop.Services.Basket.DTOs
{
    public class BasketItemDTO
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImageURL { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}