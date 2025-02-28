using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    [HttpGet]
    // public async Task<IActionResult> GetProducts()
    // {
    //     var products = await _productRepository.GetProductsAsync();
    //     return Ok(products);
    // }

    [HttpPost]
    public async Task<IActionResult> AddProduct(ProductDto productDto)
    {
        await _productRepository.AddProductAsync(productDto);
        return Ok();
    }
}