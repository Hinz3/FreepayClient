namespace Freepay.Enums
{
    public enum GatewayStatusCode
    {
        Success = 0,
        ThreeDSDeclined = 1,
        ThreeDSAuthenticationFailure = 2,
        ThreeDSAdditionalAuthenticationNeeded = 3,
        AcquirerDeclined = 4,
        SuspectedFraud = 5,
        IssuerDeclined = 6,
        InsufficientFunds = 7,
        LimitExceeded = 8,
        MerchantBlocedByCardholder = 9,
        InvalidCard = 10,
        CardExpired = 11,
        InvalidCsc = 12,
        InvalidExpiration = 13,
        LostCard = 14,
        CardRestricted = 15,
        UnsupportedCardScheme = 16,
        InternalError = 17,
        InternalCommunicationsError = 18,
        AcquirerCommunicationsError = 19,
        AcquirerProtocolError = 20,
        AcquirerInternalError = 21,
        IssuerInternalError = 22,
    }
}
