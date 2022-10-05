namespace Service.Common.Interfaces
{
    public interface ISettingService
    {
        Task<T> LoadSettingAsync<T>(Type type) where T : class;
        Task<T> LoadSettingAsync<T>() where T : class;
        Task<string> GetSettingByKeyAsync(string key, string defaultValue = "");
        Task SaveSettingAsync<T>(T settings) where T : class;
        Task CreateOrUpdateSettingsByKeyAsync(string key, string value);
    }
}
