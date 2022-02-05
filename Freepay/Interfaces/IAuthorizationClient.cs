using Freepay.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Freepay.Interfaces
{
    public interface IAuthorizationClient
    {
        /// <summary>
        /// Get detailed information about authorization.
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to get details about</param>
        /// <returns></returns>
        Task<APIResponse<Authorization>> GetAuthorization(string authorizationIdentifier);

        /// <summary>
        /// Delete client's authorization and release the locked authorized amount.
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to cancel</param>
        /// <returns></returns>
        Task<APIResponse> VoidAuthorization(string authorizationIdentifier);

        /// <summary>
        /// Capture authorization
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to capture</param>
        /// <param name="amount">Amount in minor units that you want to capture. Use this if you don't want to capture the full amount of the authorization. Optional property.</param>
        /// <returns></returns>
        Task<APIResponse<CaptureAuthorizationResponse>> CaptureAuthorization(string authorizationIdentifier, int? amount);

        /// <summary>
        /// Credit authorization
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to create credit for</param>
        /// <param name="credit"></param>
        /// <returns></returns>
        Task<APIResponse<CreditAuthorizationResponse>> CreditAuthorization(string authorizationIdentifier, CreditAuthorization credit);

        /// <summary>
        /// Get list of all credits made on authorization
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to create credit for</param>
        /// <returns></returns>
        Task<APIResponse<List<AuthorizationCredit>>> GetAuthorizationCredits(string authorizationIdentifier);

        /// <summary>
        /// Get authorization credit by identifier
        /// </summary>
        /// <param name="authorizationIdentifier">Identifier of the authorization you want to create credit for</param>
        /// <param name="creditId">Identifier of the specific credit you want to get information about</param>
        /// <returns></returns>
        Task<APIResponse<AuthorizationCredit>> GetAuthorizationCredit(string authorizationIdentifier, int creditId);
    }
}
