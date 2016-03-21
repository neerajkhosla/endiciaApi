using System;
using System.Collections.Generic;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPostageRatesResponse
	{
		string ErrorMessage
		{
			get;
		}

		IList<IPostagePrice> Postages
		{
			get;
		}

		TransactionResultEnum Status
		{
			get;
		}
	}
}