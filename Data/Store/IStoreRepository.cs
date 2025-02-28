public interface IStoreRepository
{
    Task CreateStoreAsync(CreateStoreDto createStoreDto);
    Task<List<StoreDto>> GetStoresAsync();
}