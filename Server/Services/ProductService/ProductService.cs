using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _contextService;

        public ProductService(ApplicationDbContext context)
        {
            _contextService = context;
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int Id)
        {
            var res = new ServiceResponse<Product>();
            try
            {
                res.Data = await _contextService.Products.FindAsync(Id);
                if (res.Data == null)
                {
                    throw new Exception("Product not found.");
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message;
            }

            return res;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var res = new ServiceResponse<List<Product>>();
            try
            {
                res.Data = await _contextService.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message;
            }

            return res;
        }
    }
}
