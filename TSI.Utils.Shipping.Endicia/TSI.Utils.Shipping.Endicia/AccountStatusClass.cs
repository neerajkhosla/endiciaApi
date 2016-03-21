using System;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class AccountStatusClass
	{
		internal static AccountStatusRequest ConstructAccountStatusRequest(IAccountStatusRequest request)
		{
			AccountStatusRequest result = new AccountStatusRequest()
			{
				RequesterID = ToolsClass.GetRequesterID,
				RequestID = ToolsClass.GetRequestID,
				CertifiedIntermediary = new CertifiedIntermediary()
				{
					AccountID = request.AccountID,
					PassPhrase = request.PassPhrase
				}
			};
			Logger.InternalLogDebug(string.Format("AccountStatus::ConstructAccountStatusRequest -> AccountID {0} RequestGuid {1} RequesterID {2} ", result.CertifiedIntermediary.AccountID, result.RequestID, result.RequesterID));
			return result;
		}

		internal static IAccountStatusResponse ConstructAccountStatusResponse(TSI.Utils.Shipping.Endicia.EndiciaLabelService.AccountStatusResponse response)
		{
			TSI.Utils.Shipping.Endicia.AccountStatusResponse result = new TSI.Utils.Shipping.Endicia.AccountStatusResponse();
			if (response.Status != 0)
			{
				throw new BadRequestException(response.Status, response.ErrorMessage);
			}
			result.AccountStatus = AccountStatusClass.ParseAccountStatus(response.CertifiedIntermediary.AccountStatus);
			result.AccountBalanceUSD = response.CertifiedIntermediary.PostageBalance;
			return result;
		}

		internal static AccountStatusEnum ParseAccountStatus(string status)
		{
			AccountStatusEnum accountStatusEnum;
			string str = status;
			if (str != null)
			{
				if (str != "A")
				{
					accountStatusEnum = AccountStatusEnum.UnKnown;
					return accountStatusEnum;
				}
				accountStatusEnum = AccountStatusEnum.Active;
				return accountStatusEnum;
			}
			accountStatusEnum = AccountStatusEnum.UnKnown;
			return accountStatusEnum;
		}
	}
}