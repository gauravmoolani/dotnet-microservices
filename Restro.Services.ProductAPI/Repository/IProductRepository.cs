using Restro.Services.ProductAPI.Models.Dto;

namespace Restro.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> Getproducts();
        Task<ProductDto> GetproductById(int productid);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productid);


    }
}
