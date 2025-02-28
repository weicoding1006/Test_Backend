using System.ComponentModel.DataAnnotations;

public class ProductDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
}

// 用於返回產品列表
public class ProductListDto : ProductDto
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Guid StoreId { get; set; }

}

public class CreateProductDto
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public int Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    [Required]
    public Guid StoreId { get; set; }
}