using System;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia
{
	internal static class Parsers
	{
		internal static string ParseInsuredMail(InsuredMailEnum insuredMail)
		{
			string result = string.Empty;
			switch (insuredMail)
			{
				case InsuredMailEnum.OFF:
				{
					result = "OFF";
					break;
				}
				case InsuredMailEnum.UspsOnline:
				{
					result = "UspsOnline";
					break;
				}
				case InsuredMailEnum.Endicia:
				{
					result = "Endicia";
					break;
				}
				default:
				{
					result = "OFF";
					break;
				}
			}
			return result;
		}

		internal static string ParseLabelSize(LabelSizeEnum size, LabelTypeEnum type)
		{
			string result = string.Empty;
			if (type == LabelTypeEnum.Default)
			{
				result = "4x6";
			}
			else if (type == LabelTypeEnum.Domestic)
			{
				switch (size)
				{
					case LabelSizeEnum._Default:
					case LabelSizeEnum.Domestic_4x6:
					{
						result = "4x6";
						break;
					}
					case LabelSizeEnum.InternationalDomestic_6X4:
					{
						result = "6x4";
						break;
					}
					case LabelSizeEnum.International_85X533:
					{
						result = string.Empty;
						break;
					}
					default:
					{
						goto case LabelSizeEnum.International_85X533;
					}
				}
			}
			else if (type == LabelTypeEnum.International)
			{
				switch (size)
				{
					case LabelSizeEnum._Default:
					{
						result = string.Empty;
						break;
					}
					case LabelSizeEnum.InternationalDomestic_6X4:
					{
						result = "4x6c";
						break;
					}
					case LabelSizeEnum.Domestic_4x6:
					case LabelSizeEnum.International_85X533:
					{
						result = string.Empty;
						break;
					}
					default:
					{
						goto case LabelSizeEnum.International_85X533;
					}
				}
			}
			return result;
		}

		internal static string ParseLabelType(LabelTypeEnum type)
		{
			string str;
			string result = string.Empty;
			switch (type)
			{
				case LabelTypeEnum.Default:
				{
					result = "Default";
					str = result;
					return str;
				}
                //case 2:
                //case 3:
                //{
                //    str = result;
                //    return str;
                //}
				case LabelTypeEnum.Domestic:
				{
					result = "Domestic";
					str = result;
					return str;
				}
				case LabelTypeEnum.International:
				{
					result = "International";
					str = result;
					return str;
				}
				default:
				{
					str = result;
					return str;
				}
			}
		}

		internal static string ParseMailClass(MailClassEnum mailClass)
		{
			string result = string.Empty;
			MailClassEnum mailClassEnum = mailClass;
			switch (mailClassEnum)
			{
                //case MailClassEnum.ExpressMail:
                //{
                //    result = "Express";
                //    break;
                //}
				case MailClassEnum.FirstClassMail:
				{
					result = "First";
					break;
				}
				case MailClassEnum.LibraryMail:
				{
					result = "LibraryMail";
					break;
				}
				case MailClassEnum.MediaMail:
				{
					result = "MediaMail";
					break;
				}
                //case MailClassEnum.ParcelPost:
                //{
                //    result = "ParcelPost";
                //    break;
                //}
				case MailClassEnum.ParcelSelect:
				{
					result = "ParcelSelect";
					break;
				}
				case MailClassEnum.PriorityMail:
				{
					result = "Priority";
					break;
				}
				case MailClassEnum.CriticalMail:
				{
					result = "CriticalMail";
					break;
				}
				case MailClassEnum.StandardPost:
				{
					result = "StandardPost";
					break;
				}
				default:
				{
					switch (mailClassEnum)
					{
						case MailClassEnum.ExpressMailInternational:
						{
							result = "ExpressMailInternational";
							break;
						}
						case MailClassEnum.FirstClassMailInternational:
						{
							result = "FirstClassMailInternational";
							break;
						}
						case MailClassEnum.PriorityMailInternational:
						{
							result = "PriorityMailInternational";
							break;
						}
						default:
						{
							result = string.Empty;
							break;
						}
					}
					break;
				}
			}
			return result;
		}

		internal static MailClassEnum ParseMailClass(string mailClass)
		{
			MailClassEnum result = (MailClassEnum)0;
			string str = mailClass;
			if (str != null)
			{
				switch (str)
				{
                    //case "Express":
                    //{
                    //    result = MailClassEnum.ExpressMail;
                    //    break;
                    //}
					case "First":
					{
						result = MailClassEnum.FirstClassMail;
						break;
					}
					case "LibraryMail":
					{
						result = MailClassEnum.LibraryMail;
						break;
					}
					case "MediaMail":
					{
						result = MailClassEnum.MediaMail;
						break;
					}
                    //case "ParcelPost":
                    //{
                    //    result = MailClassEnum.ParcelPost;
                    //    break;
                    //}
					case "ParcelSelect":
					{
						result = MailClassEnum.ParcelSelect;
						break;
					}
					case "Priority":
					{
						result = MailClassEnum.PriorityMail;
						break;
					}
					case "CriticalMail":
					{
						result = MailClassEnum.CriticalMail;
						break;
					}
					case "StandardMail":
					{
						result = MailClassEnum.StandardPost;
						break;
					}
					case "ExpressMailInternational":
					{
						result = MailClassEnum.ExpressMailInternational;
						break;
					}
					case "FirstClassMailInternational":
					{
						result = MailClassEnum.FirstClassMailInternational;
						break;
					}
					case "PriorityMailInternational":
					{
						result = MailClassEnum.PriorityMailInternational;
						break;
					}
				}
			}
			return result;
		}

		internal static string ParseMailpieceShape(MailpieceShapeEnum mailpieceShapeEnum)
		{
			string result = string.Empty;
			switch (mailpieceShapeEnum)
			{
				case MailpieceShapeEnum.Card:
				{
					result = "Card";
					break;
				}
				case MailpieceShapeEnum.Letter:
				{
					result = "Letter";
					break;
				}
				case MailpieceShapeEnum.Flat:
				{
					result = "Flat";
					break;
				}
				case MailpieceShapeEnum.Parcel:
				{
					result = "Parcel";
					break;
				}
				case MailpieceShapeEnum.LargeParcel:
				{
					result = "LargeParcel";
					break;
				}
				case MailpieceShapeEnum.IrregularParcel:
				{
					result = "IrregularParcel";
					break;
				}
				case MailpieceShapeEnum.OversizedParcel:
				{
					result = "OversizedParcel";
					break;
				}
				case MailpieceShapeEnum.FlatRateEnvelope:
				{
					result = "FlatRateEnvelope";
					break;
				}
				case MailpieceShapeEnum.FlatRateLegalEnvelope:
				{
					result = "FlatRateLegalEnvelope";
					break;
				}
				case MailpieceShapeEnum.FlatRatePaddedEnvelope:
				{
					result = "FlatRatePaddedEnvelope";
					break;
				}
				case MailpieceShapeEnum.FlatRateGiftCardEnvelope:
				{
					result = "FlatRateGiftCardEnvelope";
					break;
				}
				case MailpieceShapeEnum.FlatRateWindowEnvelope:
				{
					result = "FlatRateWindowEnvelope";
					break;
				}
				case MailpieceShapeEnum.FlatRateCardboardEnvelope:
				{
					result = "FlatRateCardboardEnvelope";
					break;
				}
				case MailpieceShapeEnum.SmallFlatRateEnvelope:
				{
					result = "SmallFlatRateEnvelope";
					break;
				}
				case MailpieceShapeEnum.SmallFlatRateBox:
				{
					result = "SmallFlatRateBox";
					break;
				}
				case MailpieceShapeEnum.MediumFlatRateBox:
				{
					result = "MediumFlatRateBox";
					break;
				}
				case MailpieceShapeEnum.LargeFlatRateBox:
				{
					result = "LargeFlatRateBox";
					break;
				}
				case MailpieceShapeEnum.DVDFlatRateBox:
				{
					result = "DVDFlatRateBox";
					break;
				}
				case MailpieceShapeEnum.LargeVideoFlatRateBox:
				{
					result = "LargeVideoFlatRateBox";
					break;
				}
			}
			return result;
		}

		internal static string ParsePricing(PricingEnum pricing)
		{
			string result = string.Empty;
			switch (pricing)
			{
				case PricingEnum.CommercialBase:
				{
					result = "CommercialBase";
					break;
				}
				case PricingEnum.CommercialPlus:
				{
					result = "CommercialPlus";
					break;
				}
				case PricingEnum.Retail:
				{
					result = "Retail";
					break;
				}
			}
			return result;
		}
	}
}