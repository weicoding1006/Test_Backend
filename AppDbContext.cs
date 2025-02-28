using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Store> Stores{get;set;}
    public DbSet<Product> Products{get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>()
        .HasOne(p => p.Store)
        .WithMany(s => s.Products)
        .HasForeignKey(p => p.StoreId);
    }
}