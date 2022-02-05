namespace Freepay.Models
{
    public class PaymentOption
    {
        /// <summary>
        /// TestMode Boolean flag to enable TestMode. Default is false.
        /// WARNING Do not set TestMode to true unless you are running a integration test.You will not get any money from test authorizations.
        /// More information: https://mw.freepay.dk/content/api.html#section/How-does-it-work/Testing
        /// </summary>
        public bool TestMode { get; set; }
    }
}
