using System;
using System.Collections.Generic;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPackageDetails
	{
		double Height
		{
			get;
		}

		List<IPackageItem> Items
		{
			get;
		}

		double Length
		{
			get;
		}

		double WeightOz
		{
			get;
		}

		double Width
		{
			get;
		}
	}
}