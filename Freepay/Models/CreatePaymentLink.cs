namespace Freepay.Models
{
    public class CreatePaymentLink
    {
        /// <summary>
        /// Total amount of the order. This field is required. The amount is given in minor units, which means that a decimal amount of 100.20 has to be given as 10020
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 3 char currency code of the order. This field is required.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Unique identifier of the order. This field is required. Max size of the field is 20 characters
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Boolean flag defining if Freepay should create recurrent billing handler from that order. By default this field is false.
        /// More information: https://mw.freepay.dk/content/api.html#section/How-does-it-work/SubscriptionsRecurring-orders
        /// </summary>
        public bool SaveCard { get; set; }

        /// <summary>
        /// The url to which Freepay will navigate your customer after his credit card has been processed successfully. This field is required.
        /// </summary>
        public string CustomerAcceptUrl { get; set; }

        /// <summary>
        /// The url to which Freepay will navigate your customer if there was a problem with processing of his/hers payment. This field is required.
        /// </summary>
        public string CustomerDeclineUrl { get; set; }

        /// <summary>
        /// This url is called by Freepay when the payment of your client is successfully processed. You can read more about the server callback in the following section here. This field is required.
        /// </summary>
        public string ServerCallbackUrl { get; set; }

        /// <summary>
        /// Billing information of your client.
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Shipping information of your client's order.
        /// </summary>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Subscription details. This field is required when you have SaveCard parameter set to `true` and you are billing the customer on a fixed interval for a fixed amount. 
        /// If you are billing the customer varying amounts on varying schedules, leave this field out. Note that saved cards are only allowd for merchant initiated payments. 
        /// If the customer is present you must use the payment window.
        /// </summary>
        public RecurringPayment RecurringPayment { get; set; }

        /// <summary>
        /// Enforce language is used to override the language for the payment window. 
        /// by default, the window look at the clients Accept-Language header, if the payment window recognise the culture info, it provide the window in that language. 
        /// If not, it will fallback to English. You can enforce it to always show it in a certain language by providing the culture info in this property called EnforceLanguage, which can contains a string of 5 charters, of the type shown below
        /// “da-DK” – for Danish
        /// “en-US” – for English
        /// “sv-SE” – for Swedish
        /// </summary>
        public string EnforceLanguage { get; set; }

        /// <summary>
        /// Optional options parameters for the payment.
        /// </summary>
        public PaymentOption Options { get; set; }
    }
}
