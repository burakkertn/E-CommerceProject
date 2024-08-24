using E_CommerceProject.Catalog.Abstract;
using E_CommerceProject.Catalog.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace E_CommerceProject.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("listCategory")]
        public async Task<IActionResult> ListCategory()
        {
            var listCategory = await _categoryService.GetAllCategoryAsync();
            return Ok(listCategory);
        }
        [HttpPost("createCategory")]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return Ok("Category Başarıyla Eklendi!");
        }
        [HttpDelete("deleteCategory")]
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Category Başarıyla Silindi!");
        }
        [HttpPut("updateCategory")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Category Başarıyla Güncellendi!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> ByIdCategory(string id)
        {
            var value = await _categoryService.GetByIdCategoryAsync(id);
            return Ok(value);
        }
    }
}
