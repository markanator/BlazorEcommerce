namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{id}");
            return res;
        }

        public async Task GetProductsAsync(string? categoryUrl)
        {
            var res = categoryUrl == null
                ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product")
                : await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

            if (res?.Data != null)
            {
                Products = res.Data;
            }

            // tell components that are subscribed to rerender
            ProductsChanged.Invoke();
        }
    }
}
