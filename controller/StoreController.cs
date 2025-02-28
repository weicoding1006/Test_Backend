using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    private readonly IStoreRepository _storeRepository;
    public StoreController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    [HttpGet]
    public async Task<IActionResult> GetStores()
    {
        var stores = await _storeRepository.GetStoresAsync();
        return Ok(stores);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStore(CreateStoreDto storeDto)
    {
        await _storeRepository.CreateStoreAsync(storeDto);
        return Ok();
    }
}