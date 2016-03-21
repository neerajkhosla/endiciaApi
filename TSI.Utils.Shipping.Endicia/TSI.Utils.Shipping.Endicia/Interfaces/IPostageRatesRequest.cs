using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPostageRatesRequest
	{
		string AccountID
		{
			get;
		}

		bool DeliveryConfirmation
		{
			get;
		}

		string FromPostalCode
		{
			get;
		}

		InsuredMailEnum InsuredMail
		{
			get;
		}

		LabelTypeEnum MailClass
		{
			get;
		}

		double OrderValueForInsurance
		{
			get;
		}

		IPackageDetails PackageDetails
		{
			get;
		}

		string PassPhrase
		{
			get;
		}

		bool SignatureConfirmation
		{
			get;
		}

		IAddressDetails TargetAddress
		{
			get;
		}
	}
}