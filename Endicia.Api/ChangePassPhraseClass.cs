using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    public static class ChangePassPhraseClass
    {
        public static IChangePassPhraseResponse ChangePassPhrase(string accountId, string passPhrase, string newPassPhrase)
        {
            try
            {
                ChangePassPhraseRequest request = new ChangePassPhraseRequest(accountId, passPhrase, newPassPhrase);
                IChangePassPhraseResponse response = TSI.Utils.Shipping.Endicia.Invoker.ChangePassPhrase(request);

                return response;
            }
            catch (BadRequestException)
            {
                // Nothing to do account might be disabled or not exists
                return null;
            }

        }
    }

    internal class ChangePassPhraseRequest : IChangePassPhraseRequest
    {
        internal ChangePassPhraseRequest(string accountId, string currentPassPhrase, string newPassPhrase)
        {
            this.AccountID = accountId;
            this.CurrentPassPhrase = currentPassPhrase;
            this.NewPassPhrase = newPassPhrase;
        }


        public string AccountID { get; set; }

        public string CurrentPassPhrase { get; set; }

        public string NewPassPhrase { get; set; }

    }
}
