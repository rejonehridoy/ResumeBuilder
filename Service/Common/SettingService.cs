using Data.Settings;
using OA.Repo;
using Service.Caching;
using Service.Common.Interfaces;
using System.ComponentModel;

namespace Service.Common
{
    public class SettingService : ISettingService
    {
        private readonly IRepository<Setting> settingRepository;
        private readonly IStaticCacheManager staticCacheManager;

        public SettingService(IRepository<Setting> settingRepository,
            IStaticCacheManager staticCacheManager)
        {
            this.settingRepository = settingRepository;
            this.staticCacheManager = staticCacheManager;
        }
        public async Task<List<Setting>> GetAllSettingsAsync()
        {
            string cacheKey = staticCacheManager.PrepareCacheKey(SettingsDefaults.AllSettingsKey);
            var allSettings = staticCacheManager.Get(cacheKey, async () =>
            {
                return await settingRepository.GetAllAsync();
            }
            );
            return await allSettings;
        }
        public virtual async Task<T> LoadSettingAsync<T>() where T : class
        {
            return (T)await LoadSettingAsync<T>(typeof(T));
        }
        public virtual async Task<T> LoadSettingAsync<T>(Type type) where T : class
        {
            var settings = Activator.CreateInstance(type);

            foreach (var prop in type.GetProperties())
            {
                // get properties we can read and write to
                if (!prop.CanRead || !prop.CanWrite)
                    continue;

                var key = type.Name + "." + prop.Name;
                //load key
                var setting = await GetSettingByKeyAsync(key);
                if (setting == null)
                    continue;

                if (!TypeDescriptor.GetConverter(prop.PropertyType).CanConvertFrom(typeof(string)))
                    continue;

                if (!TypeDescriptor.GetConverter(prop.PropertyType).IsValid(setting))
                    continue;

                var value = TypeDescriptor.GetConverter(prop.PropertyType).ConvertFromInvariantString(setting);

                //set property
                prop.SetValue(settings, value, null);
            }

            return settings as T;
        }

        public async Task<string> GetSettingByKeyAsync(string key, string defaultValue = "")
        {
            if (string.IsNullOrEmpty(key))
                return defaultValue;

            var settings = await GetAllSettingsAsync();
            key = key.Trim().ToLowerInvariant();
            var setting = settings.Find(s => s.Name.ToLower().Equals(key));
            if (setting == null)
                return string.Empty;
            return await Task.FromResult(setting.Value);
        }

        public virtual async Task SaveSettingAsync<T>(T settings) where T : class
        {
            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */
            foreach (var prop in typeof(T).GetProperties())
            {
                // get properties we can read and write to
                if (!prop.CanRead || !prop.CanWrite)
                    continue;

                if (!TypeDescriptor.GetConverter(prop.PropertyType).CanConvertFrom(typeof(string)))
                    continue;

                var key = typeof(T).Name + "." + prop.Name;
                var value = prop.GetValue(settings, null);
                if (value != null)
                    await SetSettingAsync(prop.PropertyType, key, value);
                else
                    await SetSettingAsync(key, string.Empty);
            }

            //and now clear cache
            await ClearCacheAsync();
        }

        protected async Task SetSettingAsync(Type type, string key, object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            key = key.Trim().ToLowerInvariant();
            var valueStr = TypeDescriptor.GetConverter(type).ConvertToInvariantString(value);

            var allSettings = await GetAllSettingsAsync();
            var existingSetting= allSettings.Where(setting => setting.Name.ToLower().Equals(key)).FirstOrDefault();
            if (existingSetting != null)
            {
                //update
                existingSetting.Value = valueStr;
                await UpdateSettingAsync(existingSetting);
            }
            else
            {
                //insert
                var setting = new Setting
                {
                    Name = key,
                    Value = valueStr,
                };
                await InsertSettingAsync(setting);
            }
        }
        public virtual async Task SetSettingAsync<T>(string key, T value)
        {
            await SetSettingAsync(typeof(T), key, value);
        }

        public async Task CreateOrUpdateSettingsByKeyAsync(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
                return;
            key = key.Trim().ToLowerInvariant();
            var setting = (await GetAllSettingsAsync()).Where(setting => setting.Name.Equals(key)).FirstOrDefault();
            if(setting != null)
            {
                setting.Value = value;
                await UpdateSettingAsync(setting);
            }
            else
            {
                //insert
                var newSetting = new Setting
                {
                    Name = key,
                    Value = value,
                };
                await InsertSettingAsync(newSetting);
            }
            //and now clear cache
            await ClearCacheAsync();
        }

        public async Task UpdateSettingAsync(Setting setting)
        {
            await settingRepository.UpdateAsync(setting);
        }

        public async Task<int> InsertSettingAsync(Setting setting)
        {
            await settingRepository.InsertAsync(setting);
            return setting.Id;
        }

        public async Task ClearCacheAsync()
        {
            await staticCacheManager.ClearCacheByKey(SettingsDefaults.AllSettingsKey);
        }

    }
}
