using System;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPackageItem
	{
		string CustomCountry
		{
			get;
		}

		string Description
		{
			get;
		}

		int Quantity
		{
			get;
		}

		decimal Value
		{
			get;
		}

		int WeightOz
		{
			get;
		}
	}
}