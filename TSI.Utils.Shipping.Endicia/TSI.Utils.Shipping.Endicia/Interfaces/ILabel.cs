using System;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface ILabel
	{
		string FileOnly
		{
			get;
		}

		string FullPathFileName
		{
			get;
		}

		string Link
		{
			get;
		}
	}
}