using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;
using TSI.Utils.Shipping.Endicia.Properties;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class PrintLabelsClass
	{
		public static LabelRequest ConstructLabelRequest(ILabelRequestRequest request)
		{
			DateTime shipDateTime;
			LabelRequest labelRequest = new LabelRequest()
			{
				Test = ToolsClass.ParseBoolYESNO(request.PrintSandbox),
				LabelType = Parsers.ParseLabelType(request.LabelType),
				LabelSize = Parsers.ParseLabelSize(request.LabelSize, request.LabelType),
				ImageFormat = ConfigManager.Current.DefaultImageFormat,
				ImageResolution = "300",
				ImageRotation = "None",
				RequesterID = ToolsClass.GetRequesterID,
				AccountID = request.AccountID,
				PassPhrase = request.PassPhrase,
				MailClass = Parsers.ParseMailClass(request.MailClass),
				DateAdvance = ConfigManager.Current.DefaultDateAdvance,
				WeightOz = request.PackageDetails.WeightOz
			};
			Dimensions dimension = new Dimensions()
			{
				Length = request.PackageDetails.Length,
				Width = request.PackageDetails.Width,
				Height = request.PackageDetails.Height
			};
			labelRequest.MailpieceDimensions = dimension;
			labelRequest.PackageTypeIndicator = ConfigManager.Current.DefaultPackageTypeIndicator;
			labelRequest.Machinable = ConfigManager.Current.DefaultMachinable;
			labelRequest.SignatureWaiver = ConfigManager.Current.DefaultSignatureWaiver;
			labelRequest.NoWeekendDelivery = ConfigManager.Current.DefaultNoWeekendDelivery;
			labelRequest.SundayHolidayDelivery = ConfigManager.Current.DefaultSundayHolidayDelivery;
			labelRequest.EntryFacility = ConfigManager.Current.DefaultEntryFacility;
			labelRequest.POZipCode = request.PoZipCode;
			bool includePostage = request.IncludePostage;
			labelRequest.IncludePostage = includePostage.ToString().ToUpper();
			labelRequest.ReplyPostage = ConfigManager.Current.DefaultReplayPostage;
			labelRequest.ShowReturnAddress = ConfigManager.Current.DefaultShowReturnAddress;
			includePostage = request.ValidateAddress;
			labelRequest.ValidateAddress = includePostage.ToString().ToUpper();
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
			labelRequest.Services = specialService;
			labelRequest.InsuredValue = request.OrderValueForInsurance;
			labelRequest.Value = (float)Convert.ToDouble(request.OrderValueForInsurance);
			labelRequest.CostCenter = 123;
			labelRequest.PartnerCustomerID = request.AccountID;
			labelRequest.PartnerTransactionID = request.TransactionId.ToString();
			labelRequest.ReferenceID = request.OrderId.ToString();
			labelRequest.RubberStamp1 = request.RubberStamp;
			ResponseOptions responseOption = new ResponseOptions()
			{
				PostagePrice = ConfigManager.Current.DefaultResponseOptions
			};
			labelRequest.ResponseOptions = responseOption;
			labelRequest.FromName = request.SenderDetails.Name;
			labelRequest.FromCompany = request.SenderDetails.Company;
			labelRequest.ReturnAddress1 = request.SenderDetails.Address1;
			labelRequest.ReturnAddress2 = request.SenderDetails.Address2;
			labelRequest.FromCity = request.SenderDetails.City;
			labelRequest.FromState = request.SenderDetails.State;
			labelRequest.FromPostalCode = request.SenderDetails.PostalCode;
			labelRequest.FromCountry = request.SenderDetails.Country;
			labelRequest.FromPhone = request.SenderDetails.Phone;
			labelRequest.FromEMail = request.SenderDetails.Email;
			labelRequest.ToName = request.TargetAddress.Name;
			labelRequest.ToCompany = request.TargetAddress.Company;
			labelRequest.ToAddress1 = request.TargetAddress.Address1;
			labelRequest.ToAddress2 = request.TargetAddress.Address2;
			labelRequest.ToCity = request.TargetAddress.City;
			labelRequest.ToState = request.TargetAddress.State;
			labelRequest.ToPostalCode = request.TargetAddress.PostalCode;
			labelRequest.ToCountry = request.TargetAddress.Country;
			labelRequest.ToCountryCode = request.TargetAddress.CountryCode;
			labelRequest.ToPhone = request.TargetAddress.Phone;
			labelRequest.ToEMail = request.TargetAddress.Email;

            //labelRequest.LabelTemplate = "abc.ly";

			LabelRequest result = labelRequest;
			if (!request.IsInternationalOrder)
			{
				result.MailpieceShape = null;
				result.LabelSubtype = ConfigManager.Current.DefaultDomesticLabelSubType;
				result.IntegratedFormType = null;
			}
			else
			{
				result.MailpieceShape = Parsers.ParseMailpieceShape(request.MailPieceShape);
				result.LabelSubtype = ConfigManager.Current.DefaultInternationalLabelSubType;
				result.IntegratedFormType = PrintLabelsClass.GetIntegratedFormType(request.IsInternationalOrder, request.MailClass, request.MailPieceShape);
			}
			if ((request.PackageDetails.Items == null ? false : request.PackageDetails.Items.Count > 0))
			{
				if (request.IsInternationalOrder)
				{
					result.CustomsCertify = ConfigManager.Current.DefaultCustomsCertify;
					result.CustomsSigner = request.CustomSigner;
					CustomsInfo customsInfo = new CustomsInfo()
					{
						CertificateNumber = request.CustomCertificateNumber,
						ContentsType = ConfigManager.Current.DefaultMerchandise,
						RestrictionType = ConfigManager.Current.DefaultRestrictionType,
						InvoiceNumber = request.InvoiceNumber,
						NonDeliveryOption = ConfigManager.Current.DefaultNonDeliveryOption
					};
					result.CustomsInfo = customsInfo;
					List<CustomsItem> items = new List<CustomsItem>();
					foreach (IPackageItem item in request.PackageDetails.Items)
					{
						CustomsItem cItem = new CustomsItem()
						{
							CountryOfOrigin = item.CustomCountry,
							Description = item.Description,
							Quantity = item.Quantity,
							Value = item.Value,
							Weight = item.WeightOz
						};
						items.Add(cItem);
					}
					result.CustomsInfo.CustomsItems = items.ToArray<CustomsItem>();
				}
			}
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

		public static ILabelRequestResponse ConstructLabelResponse(TSI.Utils.Shipping.Endicia.EndiciaLabelService.LabelRequestResponse response, ILabelRequestRequest request)
		{
			TSI.Utils.Shipping.Endicia.LabelRequestResponse result = new TSI.Utils.Shipping.Endicia.LabelRequestResponse();
			if (response.Status != 0)
			{
				result.ErrorMessage = response.ErrorMessage;
				result.Status = TransactionResultEnum.Failed;
			}
			else
			{
				result.Status = TransactionResultEnum.Succeed;
				result.ErrorMessage = response.ErrorMessage;
				result.CostCenter = response.CostCenter;
				result.CustomNumber = response.CustomsNumber;
				result.FinalPostage = response.FinalPostage;
				result.ReferenceId = response.ReferenceID;
				result.TransactionId = response.TransactionID;
				result.PostmarkDate = response.PostmarkDate;
				result.TrackingNumber = response.TrackingNumber;
				PrintLabelsClass.SaveStreamToFileAndLink(response, result, request.PhyisicalPathToSave, request.VirtualPath, request.OrderId);
			}
			return result;
		}

		private static string GetFileName(string type, int orderId, string transactionDateTime, int sequence)
		{
			object[] objArray = new object[] { type, orderId.ToString(), "_", transactionDateTime, "_", sequence, ".", Settings.Default.DefaultImageFormat };
			return string.Concat(objArray);
		}

		private static string GetIntegratedFormType(bool isInternationalShipping, MailClassEnum mailClassEnum, MailpieceShapeEnum mailpieceShapeEnum)
		{
			string str;
			bool flag;
			if (!isInternationalShipping)
			{
				str = ((mailClassEnum == MailClassEnum.FirstClassMail || mailClassEnum == MailClassEnum.PriorityMail || mailClassEnum == MailClassEnum.LibraryMail || mailClassEnum == MailClassEnum.MediaMail ? false : mailClassEnum != MailClassEnum.ParcelSelect) ? "FORM2976A" : "FORM2976");
			}
			else
			{
				if (mailClassEnum == MailClassEnum.FirstClassMailInternational)
				{
					flag = false;
				}
				else if (mailClassEnum != MailClassEnum.PriorityMailInternational)
				{
					flag = true;
				}
				else
				{
					flag = (mailpieceShapeEnum == MailpieceShapeEnum.FlatRateEnvelope || mailpieceShapeEnum == MailpieceShapeEnum.FlatRateLegalEnvelope || mailpieceShapeEnum == MailpieceShapeEnum.FlatRatePaddedEnvelope ? false : mailpieceShapeEnum != MailpieceShapeEnum.SmallFlatRateBox);
				}
				str = (flag ? "FORM2976A" : "FORM2976");
			}
			return str;
		}

		private static ILabel GetLabelData(string type, int orderId, string transactionDateTime, int sequence, string phyisicalPath, string virtualPath)
		{
			LabelData label = new LabelData();
			string fileName = PrintLabelsClass.GetFileName(type, orderId, transactionDateTime, sequence);
			label.FullPathFileName = string.Concat(phyisicalPath, fileName);
			label.FileOnly = fileName;
			label.Link = string.Concat(virtualPath, fileName);
			return label;
		}

		private static void SaveFile(ILabel label, string base64LabelImage)
		{
			FileStream file = null;
			try
			{
				try
				{
					byte[] img = Convert.FromBase64String(base64LabelImage);
					file = File.Create(label.FullPathFileName, (int)img.Length, FileOptions.None);
					file.Write(img, 0, (int)img.Length);
				}
				catch (Exception exception)
				{
					throw;
				}
			}
			finally
			{
				if (file != null)
				{
					file.Close();
				}
				file = null;
			}
		}

		private static void SaveStreamToFileAndLink(TSI.Utils.Shipping.Endicia.EndiciaLabelService.LabelRequestResponse response, TSI.Utils.Shipping.Endicia.LabelRequestResponse result, string phyisicalPathToSave, string virtualPath, int orderId)
		{
			ILabel label;
			ImageData i;
			ImageData[] image;
			int num;
			result.Labels = new List<ILabel>();
			result.CustomForms = new List<ILabel>();
			if (!Directory.Exists(phyisicalPathToSave))
			{
				Directory.CreateDirectory(phyisicalPathToSave);
			}
			try
			{
				if (!string.IsNullOrEmpty(response.Base64LabelImage))
				{
					label = PrintLabelsClass.GetLabelData("L", orderId, response.TransactionDateTime, 0, phyisicalPathToSave, virtualPath);
					PrintLabelsClass.SaveFile(label, response.Base64LabelImage);
					result.Labels.Add(label);
				}
				if (response.Label != null)
				{
					image = response.Label.Image;
					for (num = 0; num < (int)image.Length; num++)
					{
						i = image[num];
						label = PrintLabelsClass.GetLabelData("L", orderId, response.TransactionDateTime, i.PartNumber, phyisicalPathToSave, virtualPath);
						PrintLabelsClass.SaveFile(label, i.Value);
						result.Labels.Add(label);
					}
				}
				if (response.CustomsForm != null)
				{
					image = response.CustomsForm.Image;
					for (num = 0; num < (int)image.Length; num++)
					{
						i = image[num];
						label = PrintLabelsClass.GetLabelData("C", orderId, response.TransactionDateTime, i.PartNumber, phyisicalPathToSave, virtualPath);
						PrintLabelsClass.SaveFile(label, i.Value);
						result.Labels.Add(label);
					}
				}
			}
			catch (Exception exception)
			{
			}
		}
	}
}