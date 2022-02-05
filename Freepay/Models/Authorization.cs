using Freepay.Enums;
using System;
using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class Authorization
    {
        [JsonPropertyName("AuthorizationID")]
        public int AuthorizationId { get; set; }

        [JsonPropertyName("MerchantNumber")]
        public int MerchantNumber { get; set; }

        [JsonPropertyName("AuthorizationIdentifier")]
        public string AuthorizationIdentifier { get; set; }

        [JsonPropertyName("DateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonPropertyName("DateAuthorized")]
        public DateTime DateAuthorized { get; set; }

        [JsonPropertyName("DateCaptured")]
        public DateTime? DateCaptured { get; set; }

        [JsonPropertyName("Currency")]
        public string Currency { get; set; }

        [JsonPropertyName("OrderID")]
        public string OrderId { get; set; }

        [JsonPropertyName("CardType")]
        public CardType CardType { get; set; }

        [JsonPropertyName("AuthorizationAmount")]
        public int AuthorizationAmount { get; set; }

        [JsonPropertyName("IsCaptured")]
        public bool IsCaptured { get; set; }

        [JsonPropertyName("CaptureAmount")]
        public int CaptureAmount { get; set; }

        [JsonPropertyName("CaptureErrorCode")]
        public int CaptureErrorCode { get; set; }

        [JsonPropertyName("IsSubscription")]
        public bool IsSubscription { get; set; }

        [JsonPropertyName("DateSubscriptionExpires")]
        public DateTime? DateSubscriptionExpires { get; set; }

        [JsonPropertyName("DateCredited")]
        public DateTime? DateCredited { get; set; }

        [JsonPropertyName("MaskedPan")]
        public string MaskedPan { get; set; }

        [JsonPropertyName("Used3dSecure")]
        public bool Used3dSecure { get; set; }

        [JsonPropertyName("Acquirer")]
        public Acquirer Acquirer { get; set; }

        [JsonPropertyName("Status")]
        public AuthorizationStatus Status { get; set; }

        [JsonPropertyName("PaymentIdentifier")]
        public string PaymentIdentifier { get; set; }

        [JsonPropertyName("Wallet")]
        public string Wallet { get; set; }

        [JsonPropertyName("WalletProvider")]
        public WalletProvider WalletProvider { get; set; }

        [JsonPropertyName("CardExpiryDate")]
        public string CardExpiryDate { get; set; }

        [JsonPropertyName("GetFormattedAmount")]
        public decimal GetFormattedAmount { get; set; }
    }
}
