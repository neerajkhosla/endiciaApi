using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IPostageRateRequest
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

		MailClassEnum MailClass
		{
			get;
		}

		float OrderValueForInsurance
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

		PricingEnum Pricing
		{
			get;
		}

		DateTime ShipDateTime
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