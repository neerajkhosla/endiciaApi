using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IAccountStatusResponse
	{
		decimal AccountBalanceUSD
		{
			get;
		}

		AccountStatusEnum AccountStatus
		{
			get;
		}
	}
}