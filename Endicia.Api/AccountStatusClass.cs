using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    internal static class AccountStatusClass
    {
        internal static IAccountStatusResponse GetAccountStatus(string accountId, string passPhrase)
        {
            try
            {
                AccountStatusRequest request = new AccountStatusRequest(accountId, passPhrase);
                IAccountStatusResponse response = TSI.Utils.Shipping.Endicia.Invoker.GetAccountStatus(request);

                return response;
            }
            catch (BadRequestException)
            {
                // Nothing to do account might be disabled or not exists
                return null;
            }

        }
    }

    internal class AccountStatusRequest : IAccountStatusRequest
    {

        public AccountStatusRequest(string accountID, string passPhrase)
        {
            this.AccountID = accountID ?? String.Empty;
            this.PassPhrase = passPhrase ?? String.Empty;
        }

        public string AccountID { get; set; }
        public string PassPhrase { get; set; }
    }
}
