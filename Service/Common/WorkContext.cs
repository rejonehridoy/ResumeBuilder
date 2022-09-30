using Microsoft.AspNetCore.Http;
using Service.Common.Interfaces;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

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
    }
}
