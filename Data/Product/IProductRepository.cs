
public interface IProductRepository
{
    Task<List<ProductListDto>> GetProductsAsync();
    Task AddProductAsync(CreateProductDto createProductDto);
    Task DeleteProductAsync(Guid id);
}