using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Restro.Services.ProductAPI.DbContexts;
using Restro.Services.ProductAPI.Models;
using Restro.Services.ProductAPI.Models.Dto;

namespace Restro.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProductRepository(ApplicationDbContext applicationDbContext , IMapper mapper)
        {
            _db = applicationDbContext;
            _mapper = mapper;

        }
        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            if(product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productid)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(x => x.ProductId == productid);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ProductDto> GetproductById(int productid)
        {
            Product product = await _db.Products.Where(x=>x.ProductId == productid).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> Getproducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
