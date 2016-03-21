using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    internal static class BuyPostageClass
    {
        internal static IBuyPostageResponse BuyPostage(string accountId, string passPhrase, TSI.Utils.Shipping.Endicia.Enums.ReCreditAmountEnum amount)
        {
            try
            {
                BuyPostageRequest request = new BuyPostageRequest(accountId, passPhrase, amount);
                IBuyPostageResponse response = TSI.Utils.Shipping.Endicia.Invoker.BuyPostage(request);

                return response;
            }
            catch (BadRequestException)
            {
                // Nothing to do account might be disabled or not exists
                return null;
            }

        }
    }

    internal class BuyPostageRequest : IBuyPostageRequest
    {
        internal BuyPostageRequest(string accountId, string passPhrase, TSI.Utils.Shipping.Endicia.Enums.ReCreditAmountEnum amount)
        {
            this.AccountID = accountId;
            this.PassPhrase = passPhrase;
            this.Amount = amount;
        }

        public string AccountID { get; set; }
        public string PassPhrase { get; set; }
        public TSI.Utils.Shipping.Endicia.Enums.ReCreditAmountEnum Amount { get; set; }
    }
}
