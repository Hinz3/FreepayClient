namespace Freepay.Models
{
    public class CaptureAuthorization
    {
        /// <summary>
        /// Optional property. Amount in minor units that you want to capture. Use this if you don't want to capture the full amount of the authorization.
        /// </summary>
        public int? Amount { get; set; }
    }
}
