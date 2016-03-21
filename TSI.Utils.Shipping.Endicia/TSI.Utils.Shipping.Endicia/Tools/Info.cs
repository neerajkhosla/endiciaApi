using System;
using TSI.Utils.Shipping.Endicia;

namespace TSI.Utils.Shipping.Endicia.Tools
{
	public static class Info
	{
		public static string GetAdditionalDetails()
		{
			return string.Format("<div>\r\n            <div style=\"width:50%;\"class=\"section-header\">\r\n                    <div class=\"title\">Creating your account:</div>\r\n                </div>\r\n    <ul>\r\n        <li>Signup for an endicia account using the following <a href=\"{0}\">link</a>.</li>\r\n        <li>Add your account details in relvant fields of this form.</li>\r\n        <li>Perform generate PassPhrase action.</li>\r\n        <li>Perform BuyPostage action.</li>\r\n    </ul>\r\n    For any detail about endicia please visit <a href=\"http://www.endicia.com\">endicia</a> website.<br />\r\n    For any support questions, defects issues or installation on demand please email to <a href=\"mailto:endicia@tsi-integration.net\">endicia@tsi-integration.net</a>\r\n</div>", Info.GetRegistrationAccount());
		}

		internal static string GetRegistrationAccount()
		{
			return string.Concat("http://www.endicia.com/Labelserver/Login.cfm?partid=", ToolsClass.GetRequesterID);
		}
	}
}