using System;
using System.Collections.Generic;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class PostageRatesClass
	{
		internal static PostageRatesRequest ConstructPostageRatesRequest(IPostageRatesRequest request)
		{
			PostageRatesRequest result = new PostageRatesRequest()
			{
				RequesterID = ToolsClass.GetRequesterID
			};
			CertifiedIntermediary certifiedIntermediary = new CertifiedIntermediary()
			{
				AccountID = request.AccountID,
				PassPhrase = request.PassPhrase
			};
			result.CertifiedIntermediary = certifiedIntermediary;
			result.MailClass = Parsers.ParseLabelType(request.MailClass);
			result.DateAdvance = ConfigManager.Current.DefaultDateAdvance;
			result.Machinable = ConfigManager.Current.DefaultMachinable;
			SpecialServices specialService = new SpecialServices()
			{
				DeliveryConfirmation = ToolsClass.ParseBoolONOFF(request.DeliveryConfirmation),
				SignatureConfirmation = ToolsClass.ParseBoolONOFF(request.SignatureConfirmation),
				CertifiedMail = ConfigManager.Current.DefaultCertifiedMail,
				RestrictedDelivery = ConfigManager.Current.DefaultRestrictedDelivery,
				ReturnReceipt = ConfigManager.Current.DefaultReturnReceipt,
				ElectronicReturnReceipt = ConfigManager.Current.DefaultElectornicReturnReceipt,
				HoldForPickup = ConfigManager.Current.DefaultHoldForPickup,
				OpenAndDistribute = ConfigManager.Current.DefaultOpenAndDistribute,
				COD = ConfigManager.Current.DefaultCOD,
				InsuredMail = Parsers.ParseInsuredMail(request.InsuredMail),
				AdultSignature = ConfigManager.Current.DefaultAdultSignature,
				AdultSignatureRestrictedDelivery = ConfigManager.Current.DefaultAdultSignatureRestrictedDelivery
			};
			result.Services = specialService;
			result.InsuredValue = request.OrderValueForInsurance;
			result.FromPostalCode = request.FromPostalCode;
			result.ToPostalCode = request.TargetAddress.PostalCode;
			result.ToCountry = request.TargetAddress.Country;
			result.ToCountryCode = request.TargetAddress.CountryCode;
			result.WeightOz = request.PackageDetails.WeightOz;
			Dimensions dimension = new Dimensions()
			{
				Height = request.PackageDetails.Height,
				Length = request.PackageDetails.Length,
				Width = request.PackageDetails.Width
			};
			result.MailpieceDimensions = dimension;
			return result;
		}

		internal static IPostageRatesResponse ConstructPostageRatesResponse(TSI.Utils.Shipping.Endicia.EndiciaLabelService.PostageRatesResponse response)
		{
			TSI.Utils.Shipping.Endicia.PostageRatesResponse result = new TSI.Utils.Shipping.Endicia.PostageRatesResponse();
			if (response.Status == 0)
			{
				result.Status = TransactionResultEnum.Succeed;
				result.Postages = new List<IPostagePrice>();
				TSI.Utils.Shipping.Endicia.EndiciaLabelService.PostagePrice[] postagePrice = response.PostagePrice;
				for (int i = 0; i < (int)postagePrice.Length; i++)
				{
					TSI.Utils.Shipping.Endicia.EndiciaLabelService.PostagePrice price = postagePrice[i];
					IList<IPostagePrice> postages = result.Postages;
					TSI.Utils.Shipping.Endicia.PostagePrice postagePrice1 = new TSI.Utils.Shipping.Endicia.PostagePrice()
					{
						MailClass = Parsers.ParseMailClass(price.MailClass),
						MailService = price.Postage.MailService,
						TotalAmount = price.TotalAmount,
						Pricing = price.Postage.Pricing,
						Zone = price.Postage.Zone
					};
					TSI.Utils.Shipping.Endicia.Fees fee = new TSI.Utils.Shipping.Endicia.Fees()
					{
						DeliveryConfirmation = price.Fees.DeliveryConfirmation,
						InsuredMail = price.Fees.InsuredMail,
						SignatureConfirmation = price.Fees.InsuredMail,
						TotalAmount = price.Fees.TotalAmount
					};
					postagePrice1.Fees = fee;
					postages.Add(postagePrice1);
				}
			}
			else
			{
				result.ErrorMessage = response.ErrorMessage;
				result.Status = TransactionResultEnum.Failed;
			}
			return result;
		}
	}
}