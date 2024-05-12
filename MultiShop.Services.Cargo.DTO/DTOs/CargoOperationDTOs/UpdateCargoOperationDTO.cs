namespace MultiShop.Services.Cargo.DTO.DTOs.CargoOperationDTOs
{
    public class UpdateCargoOperationDTO
    {
        public int CargoOperationID { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime OperationDate { get; set; }
    }
}