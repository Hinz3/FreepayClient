using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class APIError
    {
        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}
