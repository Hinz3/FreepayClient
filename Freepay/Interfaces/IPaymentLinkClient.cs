using Freepay.Models;
using System.Threading.Tasks;

namespace Freepay.Interfaces
{
    public interface IPaymentLinkClient
    {
        /// <summary>
        /// Create payment lin
        /// </summary>
        /// <param name="createPayment">Payment link information</param>
        /// <returns></returns>
        Task<APIResponse<CreatePaymentLinkResponse>> CreateLink(CreatePaymentLink createPayment);
    }
}
