using E_CommerceProject.Catalog.Abstract;
using E_CommerceProject.Catalog.Dtos.CategoryDtos;
using E_CommerceProject.Catalog.Dtos.ProductDetailDtos;
using E_CommerceProject.Catalog.Dtos.ProductDtos;
using E_CommerceProject.Catalog.Dtos.ProductImageDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace E_CommerceProject.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageApiController : ControllerBase
    {
        private readonly IProductImageService _productImageService;
        public ProductImageApiController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet("listProductImage")]
        public async Task<IActionResult> ListProductImage()
        {
            var listProductImage = await _productImageService.GetAllProductImageAsync();
            return Ok(listProductImage);
        }
        [HttpPost("createProductImage")]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("ProductImage Başarıyla Eklendi!");
        }
        [HttpDelete("deleteProductImage")]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("ProductImage Başarıyla Silindi!");
        }
        [HttpPut("updateProductImage")]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("ProductImage Başarıyla Güncellendi!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ByIdProductImage(string id)
        {
            var value = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(value);
        }
    }
}
