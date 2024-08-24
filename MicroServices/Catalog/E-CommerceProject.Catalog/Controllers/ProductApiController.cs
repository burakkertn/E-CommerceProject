using E_CommerceProject.Catalog.Abstract;
using E_CommerceProject.Catalog.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceProject.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("listProduct")]
        public async Task<IActionResult> ListProduct()
        {
            var listProduct = await _productService.GetAllProductAsync();
            return Ok(listProduct);
        }
        [HttpPost("createProduct")]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return Ok("Product Başarıyla Eklendi!");
        }
        [HttpDelete("deleteProduct")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Product Başarıyla Silindi!");
        }
        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Product Başarıyla Güncellendi!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ByIdProduct(string id)
        {
            var value = await _productService.GetByIdProductAsync(id);
            return Ok(value);
        }
    }
}
