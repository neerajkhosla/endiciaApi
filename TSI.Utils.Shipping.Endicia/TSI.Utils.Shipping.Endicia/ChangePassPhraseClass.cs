using System;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class ChangePassPhraseClass
	{
		internal static IChangePassPhraseResponse ConstructAccountStatusResponse(ChangePassPhraseRequestResponse response)
		{
			ChangePassPhraseResponse result = new ChangePassPhraseResponse();
			if (response.Status == 0)
			{
				result.ChangeStatus = TransactionResultEnum.Succeed;
			}
			else
			{
				result.ChangeStatus = TransactionResultEnum.Failed;
			}
			return result;
		}

		internal static ChangePassPhraseRequest ConstructChangePassRequest(IChangePassPhraseRequest request)
		{
			ChangePassPhraseRequest result = new ChangePassPhraseRequest()
			{
				RequesterID = ToolsClass.GetRequesterID,
				RequestID = ToolsClass.GetRequestID,
				NewPassPhrase = request.NewPassPhrase,
				CertifiedIntermediary = new CertifiedIntermediary()
				{
					AccountID = request.AccountID,
					PassPhrase = request.CurrentPassPhrase
				}
			};
			Logger.InternalLogDebug(string.Format("ChangePassPhraseClass::ConstructChangePassRequest -> AccountID {0} RequestGuid {1} RequesterID {2} ", result.CertifiedIntermediary.AccountID, result.RequestID, result.RequesterID));
			return result;
		}
	}
}