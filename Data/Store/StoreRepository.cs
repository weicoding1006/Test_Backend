

using Microsoft.EntityFrameworkCore;

public class StoreRepository : IStoreRepository
{
    private readonly AppDbContext _context;
    public StoreRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task CreateStoreAsync(CreateStoreDto createStoreDto)
    {
        var store = new Store
        {
            Id = Guid.NewGuid(),
            Name = createStoreDto.Name,
            Description = createStoreDto.Description,
            Image = createStoreDto.Image,
            Address = createStoreDto.Address,
            Phone = createStoreDto.Phone,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        await _context.Stores.AddAsync(store);
        await _context.SaveChangesAsync();
    }

    public async Task<List<StoreDto>> GetStoresAsync()
    {
        var storeDtos = await _context.Stores
            .Include(store => store.Products) // 主動加載產品
            .Select(store => new StoreDto
            {
                Id = store.Id,
                Name = store.Name,
                Description = store.Description,
                Image = store.Image,
                Address = store.Address,
                Phone = store.Phone,
                Products = store.Products.Select(product => new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Image = product.Image,
                }).ToList()
            }).ToListAsync();

        return storeDtos;
    }
}