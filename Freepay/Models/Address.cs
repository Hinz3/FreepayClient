using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class Address
    {
        /// <summary>
        /// Address lines can have maximum 50 character. Required
        /// </summary>
        [JsonPropertyName("AddressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Extra information for Address line can have maximum 50 character. Optional
        /// </summary>
        [JsonPropertyName("AddressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Extra information for Address line can have maximum 50 character. Optional
        /// </summary>
        [JsonPropertyName("AddressLine3")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// City should can maximum 50 character. Required
        /// </summary>
        [JsonPropertyName("City")]
        public string City { get; set; }

        /// <summary>
        /// PostCode should can maximum 16 character.
        /// </summary>
        [JsonPropertyName("PostCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// Country 3 character numeric country code.
        /// List of ISO 3166-1 numeric: https://en.wikipedia.org/wiki/ISO_3166-1_numeric
        /// </summary>
        [JsonPropertyName("Country")]
        public string Country { get; set; }
    }
}
