using AutoMapper;
using Restro.Services.ProductAPI.DbContexts;
using Restro.Services.ProductAPI.Models.Dto;

namespace Restro.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDbContext applicationDbContext , IMapper mapper)
        {
            _context = applicationDbContext;
            _mapper = mapper;

        }
        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productid)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetproductById(int productid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> Getproducts()
        {
            List<ProductDto> products= 
        }
    }
}
