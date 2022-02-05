using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class RecurringAuthorization
    {
        /// <summary>
        /// Exact amount to be authorized on the saved card in minor units
        /// </summary>
        [JsonPropertyName("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Authorization order identifier
        /// </summary>
        [JsonPropertyName("OrderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Optional currency code. Formated by ISO 4217 standard. If not provided, the system will use the currency with which the subscription was created.
        /// </summary>
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }
    }
}
