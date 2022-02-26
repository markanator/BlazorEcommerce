using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var res = new ServiceResponse<List<Category>>();
            try
            {
                var categories = await _context.Categories.ToListAsync();
                if (categories != null)
                {
                    res.Data = categories;
                }
                else
                {
                    throw new Exception("Error fetching categories.");
                }
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
