using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class RecurringAuthorizationResponse
    {
        /// <summary>
        /// Credit success flag. In case the transaction was unsuccessful, the status code from the acquirer can give additional information about the problem
        /// </summary>
        [JsonPropertyName("IsSuccess")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Status code returned by the acquirer as a result of the credit transaction
        /// </summary>
        [JsonPropertyName("ErrorCode")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Unique identifier of the authorization
        /// </summary>
        [JsonPropertyName("AuthorizationIdentifier")]
        public string AuthorizationIdentifier { get; set; }

        /// <summary>
        /// Results from Acquirer and Gateway
        /// </summary>
        [JsonPropertyName("OperationResult")]
        public OperationResult OperationResult { get; set; }
    }
}
