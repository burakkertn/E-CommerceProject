using E_CommerceProject.Catalog.Dtos.ProductDtos;

namespace E_CommerceProject.Catalog.Abstract
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
    }
}
