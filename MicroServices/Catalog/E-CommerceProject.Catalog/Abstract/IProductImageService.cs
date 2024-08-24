using E_CommerceProject.Catalog.Dtos.ProductImageDtos;

namespace E_CommerceProject.Catalog.Abstract
{
    public interface IProductImageService
    {
        Task<List<ProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
    }
}
