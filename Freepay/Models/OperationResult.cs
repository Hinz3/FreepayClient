using Freepay.Enums;
using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class OperationResult
    {
        [JsonPropertyName("GatewayStatusCode")]
        public GatewayStatusCode GatewayStatusCode { get; set; }

        [JsonPropertyName("GatewayStatusMessage")]
        public string GatewayStatusMessage { get; set; }

        [JsonPropertyName("AcquirerStatusCode")]
        public string AcquirerStatusCode { get; set; }

        [JsonPropertyName("AcquirerStatusMessage")]
        public string AcquirerStatusMessage { get; set; }

        [JsonPropertyName("AcquirerName")]
        public string AcquirerName { get; set; }
    }
}
