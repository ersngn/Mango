using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> Get();
        Task<ProductDto> GetById();
        Task<ProductDto> Insert(ProductDto productDto);
        Task<bool> Delete(int productId);
    }
}
