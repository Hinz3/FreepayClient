using Freepay.Interfaces;
using Freepay.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Freepay.Implemtations
{
    public class PaymentLinkClient : IPaymentLinkClient
    {
        private readonly HttpClient client;

        public PaymentLinkClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<APIResponse<CreatePaymentLinkResponse>> CreateLink(CreatePaymentLink createPayment)
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(createPayment, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("/api/payment", content);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<CreatePaymentLinkResponse>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<CreatePaymentLinkResponse>();
            return new APIResponse<CreatePaymentLinkResponse>(result);
        }
    }
}
