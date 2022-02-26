namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetCategoriesAsync()
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (res != null && res?.Data != null)
            {
                Categories = res.Data;
            }
        }
    }
}
