using System.Text.Json.Serialization;

namespace Freepay.Models
{
    public class RecurringPayment
    {
        /// <summary>
        /// Expiration date of the subscription. After that date it won't be possible to make further authorizations on that subscription. 
        /// The format of the date provided is YYYYMMDD"
        /// </summary>
        [JsonPropertyName("Expiry")]
        public string Expiry { get; set; }

        /// <summary>
        /// How many days is the period of the subscription. Each subsequent authorization on the subscription should happen after at least the provided amount of days. 
        /// If you set the period of 30 days and make authorization after 31 days, that will be allowed but you shouldn't make authorizations before the period is elapsed. 
        /// Valid value of this field is in the range between 1 and 2000."
        /// </summary>
        [JsonPropertyName("PaymentFrequencyDays")]
        public int PaymentFrequencyDays { get; set; }
    }
}
