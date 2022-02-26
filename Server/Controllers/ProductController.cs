using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _contextService;

        public ProductController(ApplicationDbContext context)
        {
            _contextService = context;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetAllProducts()
        {
            var res = new ServiceResponse<List<Product>>();
            try
            {
                var products = await _contextService.Products.ToListAsync();

                res.Data = products;
                res.Success = products.Any();

                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
