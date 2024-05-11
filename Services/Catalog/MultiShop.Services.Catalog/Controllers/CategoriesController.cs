using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Catalog.DTOs.CategoryDTOs;
using MultiShop.Services.Catalog.Services.CategoryServices;

namespace MultiShop.Services.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(string id)
        {
            var values = await _categoryService.GetByIdCategoryAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDTO);
            return Ok("Kategori Başarıyla Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Kategori Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDTO);
            return Ok("Kategori Başarıyla Hüncellendi");
        }

        [HttpGet("GetActiveCategories")]
        public async Task<IActionResult> GetActiveCategories()
        {
            var values = await _categoryService.GetAllActiveCategoryAsync();
            return Ok(values);
        }

        [HttpGet("UpdateCategoryStatus/{id}")]
        public async Task<IActionResult> UpdateCategoryStatus(string id)
        {
            await _categoryService.UpdateCategoryStatusAsync(id);
            return Ok("Kategori Aktiflik Durum Değeri Değiştirildi");
        }

        [HttpGet("UpdateHomeStatus/{id}")]
        public async Task<IActionResult> UpdateHomeStatus(string id)
        {
            await _categoryService.UpdateCategoryStatusAsync(id);
            return Ok("Kategori Ana Sayfa Görünürlüğü Durum Değeri Değiştirildi");
        }
    }
}