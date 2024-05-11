using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Services.Catalog.DTOs.ProductDTOs;
using MultiShop.Services.Catalog.Services.ProductServices;

namespace MultiShop.Services.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService ProductService)
        {
            _productService = ProductService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GettAllProductAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var values = await _productService.GetByIdProductAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
        {
            await _productService.CreateProductAsync(createProductDTO);
            return Ok("Ürün Başarıyla Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Ürün Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            await _productService.UpdateProductAsync(updateProductDTO);
            return Ok("Ürün Başarıyla Güncellendi");
        }

        [HttpGet("GetActiveProducts")]
        public async Task<IActionResult> GetActiveProducts()
        {
            var values = await _productService.GetAllActiveProductAsync();
            return Ok(values);
        }

        [HttpGet("UpdateProductStatus/{id}")]
        public async Task<IActionResult> UpdateProductStatus(string id)
        {
            await _productService.UpdateProductStatusAsync(id);
            return Ok("Ürün Aktiflik Durum Değeri Değiştirildi");
        }

        [HttpGet("UpdateHomeStatus/{id}")]
        public async Task<IActionResult> UpdateHomeStatus(string id)
        {
            await _productService.UpdateProductStatusAsync(id);
            return Ok("Ürün Ana Sayfa Görünürlüğü Durum Değeri Değiştirildi");
        }
    }
}