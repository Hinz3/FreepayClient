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
    public class RecurringClient : IRecurringClient
    {
        private readonly HttpClient client;

        public RecurringClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<APIResponse<Authorization>> GetRecurringAgreement(string savedCardIdentifier)
        {
            var response = await client.GetAsync($"/api/recurring/{savedCardIdentifier}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<Authorization>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<Authorization>();
            return new APIResponse<Authorization>(result);
        }

        public async Task<APIResponse> DeleteRecurringAgreement(string savedCardIdentifier)
        {
            var response = await client.DeleteAsync($"/api/recurring/{savedCardIdentifier}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse(error, response.StatusCode);
            }

            return new APIResponse(true, response.StatusCode);
        }

        public async Task<APIResponse<RecurringAuthorizationResponse>> MakeRecurringAuthorization(string savedCardIdentifier, RecurringAuthorization recurringAuthorization)
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(recurringAuthorization, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/recurring/{savedCardIdentifier}/authorize", content);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<RecurringAuthorizationResponse>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<RecurringAuthorizationResponse>();
            return new APIResponse<RecurringAuthorizationResponse>(result);
        }
    }
}
