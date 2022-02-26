namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);
    }
}
