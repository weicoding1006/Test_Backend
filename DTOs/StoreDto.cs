using System.ComponentModel.DataAnnotations;

public class StoreDto
{
    public Guid Id{get;set;}
    public string? Name{get;set;}
    public string? Description{get;set;}
    public string? Image{get;set;}
    public string? Address{get;set;}
    public string? Phone{get;set;}
    public List<ProductDto>? Products{get;set;}
}

public class CreateStoreDto
{
    [Required]
    public string? Name{get;set;}
    public string? Description{get;set;}
    public string? Image{get;set;}
    public string? Address{get;set;}
    public string? Phone{get;set;}
}