namespace MultiShop.Services.Cargo.DTO.DTOs.CargoDetailDTOs
{
    public class CreateCargoDetailDTO
    {
        public string SenderCustomer { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyID { get; set; }
    }
}