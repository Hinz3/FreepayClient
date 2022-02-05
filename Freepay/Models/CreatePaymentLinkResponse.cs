using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class CreatePaymentLinkResponse
    {
        [JsonPropertyName("paymentIdentifier")]
        public string PaymentIdentifier { get; set; }

        [JsonPropertyName("paymentWindowLink")]
        public string PaymentWindowLink { get; set; }
    }
}
