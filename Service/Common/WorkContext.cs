using Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Service.Common.Interfaces;
using System.Text.Json;

namespace Service.Common
{
    public class WorkContext : IWorkContext
    {
        public string GetCurrentClientIpAddress()
        {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync("https://api.db-ip.com/v2/free/self").Result;
            var location = result.ToString();
            var data = JsonDocument.Parse(location);
            string ip = data.RootElement.GetProperty("ipAddress").ToString();
            return ip;
        }

        public List<SelectListItem> GetAllTimeZones()
        {
            string json = File.ReadAllText("wwwroot/files/timezones.json");
            var timeZones = JsonConvert.DeserializeObject<List<TimeZones>>(json);
            var list = timeZones?.Select(timezone => new SelectListItem
            {
                Text = timezone.Text,
                Value = timezone.Value
            }).ToList();
            return list ??= new List<SelectListItem>();
        }

        public DateTime GetConvertedStoreTime(DateTime utcTime)
        {
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(
                    utcTime,
                    TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time"));
            return Convert.ToDateTime(localTime.ToString("MM/dd/yyyy hh:mm tt"));
        }
    }
}
