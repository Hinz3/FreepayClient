using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class CaptureAuthorizationResponse
    {
        /// <summary>
        /// Capture success flag. In case the transaction was unsuccessful, the status code from the acquirer can give additional information about the problem
        /// </summary>
        [JsonPropertyName("IsSuccess")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Status code returned by the acquirer as a result of the capture transaction
        /// </summary>
        [JsonPropertyName("AcquirerStatusCode")]
        public int AcquirerStatusCode { get; set; }

        /// <summary>
        /// Unique identifier of the authorization
        /// </summary>
        [JsonPropertyName("Identifier")]
        public string Identifier { get; set; }
    }
}
