using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IBuyPostageRequest
	{
		string AccountID
		{
			get;
		}

		ReCreditAmountEnum Amount
		{
			get;
		}

		string PassPhrase
		{
			get;
		}
	}
}