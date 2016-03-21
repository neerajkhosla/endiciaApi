using System;
using System.Text;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class ToolsClass
	{
		internal static string GetRequesterID
		{
			get
			{
				string str = Encoding.UTF8.GetString(new byte[] { 108, 116, 115, 105 });
				return str;
			}
		}

		internal static string GetRequestID
		{
			get
			{
				return Guid.NewGuid().ToString();
			}
		}

		internal static string ParseBoolONOFF(bool val)
		{
			return (val ? "ON" : "OFF");
		}

		internal static string ParseBoolYESNO(bool val)
		{
			return (val ? "YES" : "NO");
		}
	}
}