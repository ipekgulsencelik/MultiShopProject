using MultiShop.Services.Catalog.DTOs.CategoryDTOs;

namespace MultiShop.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDTO>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
        Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDTO> GetByIdCategoryAsync(string id);
        Task<List<ResultCategoryDTO>> GetAllActiveCategoryAsync();
        Task UpdateCategoryStatusAsync(string id);
        Task UpdateHomeStatusAsync(string id);
    }
}