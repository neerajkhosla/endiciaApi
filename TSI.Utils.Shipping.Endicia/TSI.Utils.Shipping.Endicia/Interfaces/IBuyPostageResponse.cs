using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IBuyPostageResponse : IAccountStatusResponse
	{
		string ErrorMessage
		{
			get;
		}

		TransactionResultEnum RecreditStatus
		{
			get;
		}
	}
}