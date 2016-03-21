using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class ShippingInfo
	{
		internal static void Info(params KeyValuePair<string, string>[] values)
		{
			try
			{
				ASCIIEncoding encoding = new ASCIIEncoding();
				string postData = "";
				KeyValuePair<string, string>[] keyValuePairArray = values;
				for (int i = 0; i < (int)keyValuePairArray.Length; i++)
				{
					KeyValuePair<string, string> pair = keyValuePairArray[i];
					string str = postData;
					string[] key = new string[] { str, pair.Key, "=", pair.Value, "&" };
					postData = string.Concat(key);
				}
				if (postData.Length > 0)
				{
					postData = postData.Substring(0, postData.Length - 1);
				}
				byte[] data = encoding.GetBytes(postData);
				HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://tsi-integration.net/WS/ShippingLabel.ashx");
				myRequest.Method = "POST";
				myRequest.ContentType = "application/x-www-form-urlencoded";
				myRequest.ContentLength = (long)((int)data.Length);
				myRequest.Timeout = 3000;
				Stream newStream = myRequest.GetRequestStream();
				newStream.Write(data, 0, (int)data.Length);
				newStream.Close();
			}
			catch
			{
			}
		}
	}
}