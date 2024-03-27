using MultiShop.Services.Catalog.DTOs.ProductDTOs;

namespace MultiShop.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDTO>> GettAllProductAsync();
        Task CreateProductAsync(CreateProductDTO createProductDTO);
        Task UpdateProductAsync(UpdateProductDTO updateProductDTO);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDTO> GetByIdProductAsync(string id);
        Task<List<ResultProductDTO>> GetAllActiveProductAsync();
        Task UpdateProductStatusAsync(string id);
        Task UpdateHomeStatusAsync(string id);
    }
}