using E_CommerceProject.Catalog.Dtos.CategoryDtos;

namespace E_CommerceProject.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }

    }
}
