using System;
using System.Runtime.CompilerServices;

namespace TSI.Utils.Shipping.Endicia
{
	public class BadRequestException : Exception
	{
		public int ErrorCode
		{
			get;
			set;
		}

		internal BadRequestException(int errCode, string errMessage) : base(errMessage)
		{
			this.ErrorCode = errCode;
		}
	}
}