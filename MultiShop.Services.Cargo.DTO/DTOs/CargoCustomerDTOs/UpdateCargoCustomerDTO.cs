﻿namespace MultiShop.Services.Cargo.DTO.DTOs.CargoCustomerDTOs
{
    public class UpdateCargoCustomerDTO
    {
        public int CargoCustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string UserCustomerID { get; set; }
    }
}