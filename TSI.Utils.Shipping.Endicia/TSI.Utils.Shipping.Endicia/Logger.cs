using System;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class Logger
	{
		internal static void ExternalLogDebug(ILogger logger, string message)
		{
			if (logger != null)
			{
				logger.Debug(message);
			}
		}

		internal static void InternalLogDebug(string message)
		{
		}
	}
}