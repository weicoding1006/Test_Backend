using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<ProductListDto>> GetProductsAsync()
    {
        return await _context.Products.Select(product => new ProductListDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image,
            CreatedAt = product.CreatedAt,
            UpdatedAt = product.UpdatedAt,
            StoreId = product.StoreId
        }).ToListAsync();
    }
    public async Task AddProductAsync(CreateProductDto createProductDto)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = createProductDto.Name,
            Price = createProductDto.Price,
            Description = createProductDto.Description,
            Image = createProductDto.Image,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            StoreId = createProductDto.StoreId
        };
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(Guid id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Product not found");
        }
    }
}