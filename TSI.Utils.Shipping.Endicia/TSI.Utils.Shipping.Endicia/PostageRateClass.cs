using System;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class PostageRateClass
	{
		internal static PostageRateRequest ConstructPostageRateRequest(IPostageRateRequest request)
		{
			DateTime shipDateTime;
			PostageRateRequest postageRateRequest = new PostageRateRequest()
			{
				RequesterID = ToolsClass.GetRequesterID
			};
			CertifiedIntermediary certifiedIntermediary = new CertifiedIntermediary()
			{
				AccountID = request.AccountID,
				PassPhrase = request.PassPhrase
			};
			postageRateRequest.CertifiedIntermediary = certifiedIntermediary;
			postageRateRequest.DateAdvance = ConfigManager.Current.DefaultDateAdvance;
			postageRateRequest.Pricing = Parsers.ParsePricing(request.Pricing);
			postageRateRequest.WeightOz = request.PackageDetails.WeightOz;
			Dimensions dimension = new Dimensions()
			{
				Height = request.PackageDetails.Height,
				Width = request.PackageDetails.Width,
				Length = request.PackageDetails.Length
			};
			postageRateRequest.MailpieceDimensions = dimension;
			postageRateRequest.AutomationRate = ConfigManager.Current.DefaultAutomationRate;
			postageRateRequest.PackageTypeIndicator = ConfigManager.Current.DefaultPackageTypeIndicator;
			postageRateRequest.Machinable = ConfigManager.Current.DefaultMachinable;
			postageRateRequest.ServiceLevel = ConfigManager.Current.DefaultServiceLevel;
			postageRateRequest.SundayHolidayDelivery = ConfigManager.Current.DefaultSundayHolidayDelivery;
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
			postageRateRequest.Services = specialService;
			postageRateRequest.EntryFacility = ConfigManager.Current.DefaultEntryFacility;
			postageRateRequest.Value = request.OrderValueForInsurance;
			postageRateRequest.InsuredValue = request.OrderValueForInsurance.ToString();
			postageRateRequest.FromPostalCode = request.FromPostalCode;
			postageRateRequest.ToPostalCode = request.TargetAddress.PostalCode;
			postageRateRequest.ToCountry = request.TargetAddress.Country;
			postageRateRequest.ToCountryCode = request.TargetAddress.CountryCode;
			ResponseOptions responseOption = new ResponseOptions()
			{
				PostagePrice = ConfigManager.Current.DefaultResponseOptions
			};
			postageRateRequest.ResponseOptions = responseOption;
			postageRateRequest.MailClass = Parsers.ParseMailClass(request.MailClass);
			PostageRateRequest result = postageRateRequest;
			try
			{
				shipDateTime = request.ShipDateTime;
				result.ShipDate = shipDateTime.ToString("MM/dd/yyyy");
			}
			catch
			{
				shipDateTime = DateTime.Now;
				result.ShipDate = shipDateTime.ToString("MM/dd/yyyy");
			}
			try
			{
				shipDateTime = request.ShipDateTime;
				result.ShipTime = shipDateTime.ToString("hh:mm tt");
			}
			catch
			{
				shipDateTime = DateTime.Now;
				result.ShipDate = shipDateTime.ToString("hh:mm tt");
			}
			return result;
		}

		internal static IPostageRateResponse ConstructPostageRateResponse(TSI.Utils.Shipping.Endicia.EndiciaLabelService.PostageRateResponse response)
		{
			return new TSI.Utils.Shipping.Endicia.PostageRateResponse();
		}
	}
}