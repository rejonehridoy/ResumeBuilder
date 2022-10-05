using System.Text.Json.Serialization;

namespace Core
{
    [Serializable]
    public class TimeZones
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("abbr")]
        public string Abbr { get; set; }

        [JsonPropertyName("offset")]
        public decimal Offset { get; set; }

        [JsonPropertyName("isdst")]
        public bool IsDst { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("utc")]
        public List<string> Utc { get; set; }
    }
}
