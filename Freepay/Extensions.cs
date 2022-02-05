using Freepay.Configurations;
using Freepay.Implemtations;
using Freepay.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http.Headers;
using System.Text;

namespace Freepay
{
    public static class Extensions
    {
        public static IServiceCollection UseFreepay(this IServiceCollection services, IConfiguration configuration, string appSettingsPath = "Freepay")
        {
            var config = configuration.GetSection(appSettingsPath).Get<FreepayConfiguration>();

            services.UseFreepay(config.GatewayApiUrl, config.PaymentApiUrl, config.ApiKey);

            return services;
        }

        public static IServiceCollection UseFreepay(this IServiceCollection services, string gatewayApiUrl, string paymentApiUrl, string apiKey)
        {
            services.AddHttpClient<IPaymentLinkClient, PaymentLinkClient>(conf =>
            {
                var byteArray = Encoding.ASCII.GetBytes($"{apiKey}:");
                string encodeString = Convert.ToBase64String(byteArray);

                conf.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodeString);
                conf.BaseAddress = new Uri(gatewayApiUrl);
            });

            services.AddHttpClient<IAuthorizationClient, AuthorizationClient>(conf =>
            {
                var byteArray = Encoding.ASCII.GetBytes($"{apiKey}:");
                string encodeString = Convert.ToBase64String(byteArray);

                conf.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodeString);
                conf.BaseAddress = new Uri(paymentApiUrl);
            });

            services.AddHttpClient<IRecurringClient, RecurringClient>(conf =>
            {
                var byteArray = Encoding.ASCII.GetBytes($"{apiKey}:");
                string encodeString = Convert.ToBase64String(byteArray);

                conf.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodeString);
                conf.BaseAddress = new Uri(paymentApiUrl);
            });

            return services;
        }
    }
}
