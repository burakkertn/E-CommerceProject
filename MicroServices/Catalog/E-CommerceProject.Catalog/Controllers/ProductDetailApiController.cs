using E_CommerceProject.Catalog.Abstract;
using E_CommerceProject.Catalog.Dtos.CategoryDtos;
using E_CommerceProject.Catalog.Dtos.ProductDetailDtos;
using E_CommerceProject.Catalog.Dtos.ProductDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace E_CommerceProject.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailApiController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;
        public ProductDetailApiController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }
        [HttpGet("listProductDetail")]
        public async Task<IActionResult> ListProductDetail()
        {
            var listProductDetail = await _productDetailService.GetAllProductDetailAsync();
            return Ok(listProductDetail);
        }
        [HttpPost("createProductDetail")]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _productDetailService.CreateProductDetailAsync(createProductDetailDto);
            return Ok("ProductDetail Başarıyla Eklendi!");
        }
        [HttpDelete("deleteProductDetail")]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _productDetailService.DeleteProductDetailAsync(id);
            return Ok("ProductDetail Başarıyla Silindi!");
        }
        [HttpPut("updateProductDetail")]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _productDetailService.UpdateProductDetailAsync(updateProductDetailDto);
            return Ok("ProductDetail Başarıyla Güncellendi!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ByIdProductDetail(string id)
        {
            var value = await _productDetailService.GetByIdProductDetailAsync(id);
            return Ok(value);
        }
    }
}
