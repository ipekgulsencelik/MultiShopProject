namespace MultiShop.Services.Cargo.DTO.DTOs.CargoDetailDTOs
{
    public class UpdateCargoDetailDTO
    {
        public int CargoDetailID { get; set; }
        public string SenderCustomer { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyID { get; set; }
    }
}