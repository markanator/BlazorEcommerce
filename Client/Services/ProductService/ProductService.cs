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

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetProductsAsync()
        {
            var res = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            if (res?.Data != null)
            {
                Products = res.Data;
            }
        }
    }
}
