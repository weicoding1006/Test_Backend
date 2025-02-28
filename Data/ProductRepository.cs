using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
    public async Task AddProductAsync(ProductDto productDto)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = productDto.Name,
            Price = productDto.Price,
            Description = productDto.Description,
            Image = productDto.Image,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }
}