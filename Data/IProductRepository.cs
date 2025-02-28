
public interface IProductRepository
{
    Task<List<Product>> GetProductsAsync();
    Task AddProductAsync(ProductDto productDto);
}