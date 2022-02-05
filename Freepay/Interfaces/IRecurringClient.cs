using Freepay.Models;
using System.Threading.Tasks;

namespace Freepay.Interfaces
{
    public interface IRecurringClient
    {
        /// <summary>
        /// Get information about recurring payment agreement
        /// </summary>
        /// <param name="savedCardIdentifier">Identifier of the recurring payment agreement</param>
        /// <returns></returns>
        Task<APIResponse<Authorization>> GetRecurringAgreement(string savedCardIdentifier);

        /// <summary>
        /// Delete recurring payment agreement
        /// </summary>
        /// <param name="savedCardIdentifier">Identifier of the recurring payment agreement</param>
        /// <returns></returns>
        Task<APIResponse> DeleteRecurringAgreement(string savedCardIdentifier);

        /// <summary>
        /// Make recurring authorization
        /// </summary>
        /// <param name="savedCardIdentifier">Identifier of the recurring payment agreement</param>
        /// <param name="recurringAuthorization"></param>
        /// <returns></returns>
        Task<APIResponse<RecurringAuthorizationResponse>> MakeRecurringAuthorization(string savedCardIdentifier, RecurringAuthorization recurringAuthorization);
    }
}
