using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface ILabelRequestRequest
	{
		string AccountID
		{
			get;
		}

		int CostCetner
		{
			get;
		}

		string CustomCertificateNumber
		{
			get;
		}

		string CustomSigner
		{
			get;
		}

		bool DeliveryConfirmation
		{
			get;
		}

		bool IncludePostage
		{
			get;
		}

		InsuredMailEnum InsuredMail
		{
			get;
		}

		string InvoiceNumber
		{
			get;
		}

		bool IsInternationalOrder
		{
			get;
		}

		LabelSizeEnum LabelSize
		{
			get;
		}

		LabelTypeEnum LabelType
		{
			get;
		}

		MailClassEnum MailClass
		{
			get;
		}

		MailpieceShapeEnum MailPieceShape
		{
			get;
		}

		int OrderId
		{
			get;
		}

		string OrderValueForInsurance
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

		string PhyisicalPathToSave
		{
			get;
		}

		string PoZipCode
		{
			get;
		}

		bool PrintSandbox
		{
			get;
		}

		string RubberStamp
		{
			get;
		}

		IAddressDetails SenderDetails
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

		int TransactionId
		{
			get;
		}

		bool ValidateAddress
		{
			get;
		}

		string VirtualPath
		{
			get;
		}
	}
}