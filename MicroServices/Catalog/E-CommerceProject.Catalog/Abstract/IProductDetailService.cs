using E_CommerceProject.Catalog.Dtos.ProductDetailDtos;

namespace E_CommerceProject.Catalog.Abstract
{
    public interface IProductDetailService
    {
        Task<List<ProductDetailDto>> GetAllProductDetailAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string id);
        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
    }
}
