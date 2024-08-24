using E_CommerceProject.Catalog.Dtos.CategoryDtos;

namespace E_CommerceProject.Catalog.Abstract
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
    }
}
