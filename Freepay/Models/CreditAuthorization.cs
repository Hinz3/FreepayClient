using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class CreditAuthorization
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
    }
}
