using Freepay.Interfaces;
using Freepay.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Authorization = Freepay.Models.Authorization;

namespace Freepay.Implemtations
{
    public class AuthorizationClient : IAuthorizationClient
    {
        private readonly HttpClient client;

        public AuthorizationClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<APIResponse<Authorization>> GetAuthorization(string authorizationIdentifier)
        {
            var response = await client.GetAsync($"/api/authorization/{authorizationIdentifier}");
            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotAcceptable)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<Authorization>(error, response.StatusCode);
            }
            else if (response.StatusCode == HttpStatusCode.NotAcceptable)
            {
                var error = new APIError { Message = "No matching authorization found" };
                return new APIResponse<Authorization>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<Authorization>();
            return new APIResponse<Authorization>(result);
        }

        public async Task<APIResponse> VoidAuthorization(string authorizationIdentifier)
        {
            var response = await client.DeleteAsync($"/api/authorization/{authorizationIdentifier}");
            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotAcceptable)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse(error, response.StatusCode);
            }
            else if (response.StatusCode == HttpStatusCode.NotAcceptable)
            {
                var error = new APIError { Message = "No matching authorization found" };
                return new APIResponse(error, response.StatusCode);
            }

            return new APIResponse(true, response.StatusCode);
        }

        public async Task<APIResponse<CaptureAuthorizationResponse>> CaptureAuthorization(string authorizationIdentifier, int? amount)
        {
            var body = new CaptureAuthorization { Amount = amount };
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(body, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/authorization/{authorizationIdentifier}/capture", content);
            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotAcceptable)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<CaptureAuthorizationResponse>(error, response.StatusCode);
            }
            else if (response.StatusCode == HttpStatusCode.NotAcceptable)
            {
                var error = new APIError { Message = "No matching authorization found" };
                return new APIResponse<CaptureAuthorizationResponse>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<CaptureAuthorizationResponse>();
            return new APIResponse<CaptureAuthorizationResponse>(result);
        }

        public async Task<APIResponse<CreditAuthorizationResponse>> CreditAuthorization(string authorizationIdentifier, CreditAuthorization credit)
        {
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };

            var json = JsonSerializer.Serialize(credit, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/authorization/{authorizationIdentifier}/credit", content);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<CreditAuthorizationResponse>(error, response.StatusCode);
            }

            var result = await response.Content.ReadFromJsonAsync<CreditAuthorizationResponse>();
            return new APIResponse<CreditAuthorizationResponse>(result);
        }

        public async Task<APIResponse<List<AuthorizationCredit>>> GetAuthorizationCredits(string authorizationIdentifier)
        {
            var response = await client.GetAsync($"/api/authorization/{authorizationIdentifier}/credit");
            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotAcceptable)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<List<AuthorizationCredit>>(error, response.StatusCode);
            }
            else if (response.StatusCode == HttpStatusCode.NotAcceptable)
            {
                var error = new APIError { Message = "No matching authorization found" };
                return new APIResponse<List<AuthorizationCredit>>(error, response.StatusCode);
            }

            var credits = await response.Content.ReadFromJsonAsync<List<AuthorizationCredit>>();
            return new APIResponse<List<AuthorizationCredit>>(credits);
        }

        public async Task<APIResponse<AuthorizationCredit>> GetAuthorizationCredit(string authorizationIdentifier, int creditId)
        {
            var response = await client.GetAsync($"/api/authorization/{authorizationIdentifier}/credit/{creditId}");
            if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotAcceptable)
            {
                var error = await response.Content.ReadFromJsonAsync<APIError>();
                return new APIResponse<AuthorizationCredit>(error, response.StatusCode);
            }
            else if (response.StatusCode == HttpStatusCode.NotAcceptable)
            {
                var error = new APIError { Message = "No matching authorization found" };
                return new APIResponse<AuthorizationCredit>(error, response.StatusCode);
            }

            var credit = await response.Content.ReadFromJsonAsync<AuthorizationCredit>();
            return new APIResponse<AuthorizationCredit>(credit);
        }
    }
}
