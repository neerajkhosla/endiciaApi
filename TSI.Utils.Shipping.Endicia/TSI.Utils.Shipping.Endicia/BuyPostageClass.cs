using System;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class BuyPostageClass
	{
		internal static RecreditRequest ConstructBuyPostageRequest(IBuyPostageRequest request)
		{
			RecreditRequest result = new RecreditRequest()
			{
				RequesterID = ToolsClass.GetRequesterID,
				RequestID = ToolsClass.GetRequestID,
				RecreditAmount = request.Amount.ToString(),
				CertifiedIntermediary = new CertifiedIntermediary()
				{
					AccountID = request.AccountID,
					PassPhrase = request.PassPhrase
				}
			};
			Logger.InternalLogDebug(string.Format("BuyPostageClass::ConstructBuyPostageRequest -> AccountID {0} RequestGuid {1} RequesterID {2} ", result.CertifiedIntermediary.AccountID, result.RequestID, result.RequesterID));
			return result;
		}

		internal static IBuyPostageResponse ConstructBuyPostageResponse(RecreditRequestResponse response)
		{
			BuyPostageResponse result = new BuyPostageResponse();
			if (response.Status == 0)
			{
				result.RecreditStatus = TransactionResultEnum.Succeed;
				result.AccountStatus = AccountStatusClass.ParseAccountStatus(response.CertifiedIntermediary.AccountStatus);
				result.AccountBalanceUSD = response.CertifiedIntermediary.PostageBalance;
			}
			else
			{
				result.ErrorMessage = response.ErrorMessage;
				result.RecreditStatus = TransactionResultEnum.Failed;
			}
			return result;
		}
	}
}