using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPostagePrice
	{
		IFees Fees
		{
			get;
		}

		MailClassEnum MailClass
		{
			get;
		}

		string MailService
		{
			get;
		}

		string Pricing
		{
			get;
		}

		decimal TotalAmount
		{
			get;
		}

		string Zone
		{
			get;
		}
	}
}