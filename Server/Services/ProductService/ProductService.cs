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
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var res = new ServiceResponse<List<Product>>();
            try
            {
                res.Data = await _contextService.Products.ToListAsync(); ;
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
