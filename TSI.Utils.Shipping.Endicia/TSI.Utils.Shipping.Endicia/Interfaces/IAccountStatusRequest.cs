using System;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IAccountStatusRequest
	{
		string AccountID
		{
			get;
		}

		string PassPhrase
		{
			get;
		}
	}
}