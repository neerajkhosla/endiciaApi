using System;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IFees
	{
		decimal DeliveryConfirmation
		{
			get;
		}

		decimal InsuredMail
		{
			get;
		}

		decimal SignatureConfirmation
		{
			get;
		}

		decimal TotalAmount
		{
			get;
		}
	}
}