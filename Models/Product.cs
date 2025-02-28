using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public Guid Id {get;set;}
    [Required]
    public string? Name {get;set;}
    [Required]
    public int Price{get;set;}
    public string? Description{get;set;}
    public string? Image{get;set;}
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
}

public class ProductDto
{
    [Required]
    public string? Name {get;set;}
    [Required]
    public int Price{get;set;}
    public string? Description{get;set;}
    public string? Image{get;set;}
}