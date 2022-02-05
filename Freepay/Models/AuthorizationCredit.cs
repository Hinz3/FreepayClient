using System;
using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class AuthorizationCredit
    {
        /// <summary>
        /// Exact amount to be credited from the transaction. The amount is provided in minor units.
        /// </summary>
        [JsonPropertyName("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Optional comment or notes about the refund
        /// </summary>
        [JsonPropertyName("Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Creation date of the credit
        /// </summary>
        [JsonPropertyName("DateCreated")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Id of the authorization that was credited
        /// </summary>
        [JsonPropertyName("AuthorizationId")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Unique identifier of the authorization
        /// </summary>
        [JsonPropertyName("Identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Success flag showing if the credit transaction was successful
        /// </summary>
        [JsonPropertyName("IsSuccess")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Status code response from the acquirer handling the transaction
        /// </summary>
        [JsonPropertyName("AcquirerStatusCode")]
        public int AcquirerStatusCode { get; set; }
    }
}
