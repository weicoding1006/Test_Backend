using System.ComponentModel.DataAnnotations;

public class Store
{
    [Key]
    public Guid Id {get;set;}
    [Required]
    public string? Name{get;set;}
    public string? Description{get;set;}
    public string? Image{get;set;}
    public string? Address{get;set;}
    public string? Phone{get;set;}
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
    public ICollection<Product> Products{get;set;} = new List<Product>();
}


