using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia.Enums;

namespace Endicia.Api
{
    public class MailPieceClass
    {
        #region CTOR
        public MailPieceClass(MailpieceShapeEnum mailpiece)
        {
            this.MailPiece = mailpiece;
            this.MailPieceName = MailPieceClass.GetMailPieceName(mailpiece);
            this.IsDomestic = MailPieceClass.IsDomesticPiece(MailPiece);
            this.IsInternational = MailPieceClass.IsInternationalPiece(MailPiece);
        }

        public MailPieceClass(string mailPieceName)
        {
            this.MailPieceName = mailPieceName;
            this.MailPiece = MailPieceClass.GetMailPieceEnum(mailPieceName);
            this.IsDomestic = MailPieceClass.IsDomesticPiece(this.MailPiece);
            this.IsInternational = MailPieceClass.IsInternationalPiece(this.MailPiece);
        }
        #endregion

        #region fileds
        public MailpieceShapeEnum MailPiece { get; set; }
        public string MailPieceName { get; set; }
        public bool IsDomestic { get; set; }
        public bool IsInternational { get; set; }
        #endregion

        #region Static
        internal static string GetMailPieceName(MailpieceShapeEnum mailpiece)
        {
            switch (mailpiece)
            {
                case MailpieceShapeEnum.Card:
                    return "Card";
                case MailpieceShapeEnum.DVDFlatRateBox:
                    return "DVD Flat Rate Box";
                case MailpieceShapeEnum.Flat:
                    return "Flat";
                case MailpieceShapeEnum.FlatRateCardboardEnvelope:
                    return "Flat Rate Cardboard Envelope";
                case MailpieceShapeEnum.FlatRateEnvelope:
                    return "Flat Rate Evnelope";
                case MailpieceShapeEnum.FlatRateGiftCardEnvelope:
                    return "Flat Rate Giftcard Envelope";
                case MailpieceShapeEnum.FlatRateLegalEnvelope:
                    return "Flat Rate Legal Envelope";
                case MailpieceShapeEnum.FlatRatePaddedEnvelope:
                    return "Flat Rate Padded Envelope";
                case MailpieceShapeEnum.FlatRateWindowEnvelope:
                    return "Flat Rate Window Envelope";
                case MailpieceShapeEnum.IrregularParcel:
                    return "Irregular Parcel";
                case MailpieceShapeEnum.LargeFlatRateBox:
                    return "Large Flat Rate Box";
                case MailpieceShapeEnum.LargeParcel:
                    return "Large Parcel";
                case MailpieceShapeEnum.LargeVideoFlatRateBox:
                    return "Large Video Flat Rate Box";
                case MailpieceShapeEnum.Letter:
                    return "Letter";
                case MailpieceShapeEnum.MediumFlatRateBox:
                    return "Medium Flat Rate Box";
                case MailpieceShapeEnum.OversizedParcel:
                    return "Oversized Parcel";
                case MailpieceShapeEnum.Parcel:
                    return "Parcel";
                case MailpieceShapeEnum.SmallFlatRateBox:
                    return "Small Flat Rate Box";
                case MailpieceShapeEnum.SmallFlatRateEnvelope:
                    return "Small Flat Rate Envelope";
                default:
                    return "";
            }
        }
        internal static MailpieceShapeEnum GetMailPieceEnum(string mailpieceName)
        {
            switch (mailpieceName)
            {
                case "Card":
                    return MailpieceShapeEnum.Card;
                case "DVD Flat Rate Box":
                    return MailpieceShapeEnum.DVDFlatRateBox;
                case "Flat":
                    return MailpieceShapeEnum.Flat;
                case "Flat Rate Cardboard Envelope":
                    return MailpieceShapeEnum.FlatRateCardboardEnvelope;
                case "Flat Rate Evnelope":
                    return MailpieceShapeEnum.FlatRateEnvelope;
                case "Flat Rate Giftcard Envelope":
                    return MailpieceShapeEnum.FlatRateGiftCardEnvelope;
                case "Flat Rate Legal Envelope":
                    return MailpieceShapeEnum.FlatRateLegalEnvelope;
                case "Flat Rate Padded Envelope":
                    return MailpieceShapeEnum.FlatRatePaddedEnvelope;
                case "Flat Rate Window Envelope":
                    return MailpieceShapeEnum.FlatRateWindowEnvelope;
                case "Irregular Parcel":
                    return MailpieceShapeEnum.IrregularParcel;
                case "Large Flat Rate Box":
                    return MailpieceShapeEnum.LargeFlatRateBox;
                case "Large Parcel":
                    return MailpieceShapeEnum.LargeParcel;
                case "Large Video Flat Rate Box":
                    return MailpieceShapeEnum.LargeVideoFlatRateBox;
                case "Letter":
                    return MailpieceShapeEnum.Letter;
                case "Medium Flat Rate Box":
                    return MailpieceShapeEnum.MediumFlatRateBox;
                case "Oversized Parcel":
                    return MailpieceShapeEnum.OversizedParcel;
                case "Parcel":
                    return MailpieceShapeEnum.Parcel;
                case "Small Flat Rate Box":
                    return MailpieceShapeEnum.SmallFlatRateBox;
                case "Small Flat Rate Envelope":
                    return MailpieceShapeEnum.SmallFlatRateEnvelope;
            }
            return default(MailpieceShapeEnum);
        }
        internal static bool IsDomesticPiece(MailpieceShapeEnum mailPiece)
        {
            switch (mailPiece)
            {
                case MailpieceShapeEnum.Parcel:
                case MailpieceShapeEnum.LargeParcel:
                case MailpieceShapeEnum.IrregularParcel:
                case MailpieceShapeEnum.FlatRateCardboardEnvelope:
                case MailpieceShapeEnum.FlatRateEnvelope:
                case MailpieceShapeEnum.FlatRateGiftCardEnvelope:
                case MailpieceShapeEnum.FlatRateLegalEnvelope:
                case MailpieceShapeEnum.FlatRatePaddedEnvelope:
                case MailpieceShapeEnum.FlatRateWindowEnvelope:
                case MailpieceShapeEnum.SmallFlatRateBox:
                case MailpieceShapeEnum.SmallFlatRateEnvelope:
                case MailpieceShapeEnum.LargeFlatRateBox:
                case MailpieceShapeEnum.LargeVideoFlatRateBox:
                case MailpieceShapeEnum.MediumFlatRateBox:
                    return true;
                case MailpieceShapeEnum.Card:
                case MailpieceShapeEnum.OversizedParcel:
                case MailpieceShapeEnum.Flat:
                case MailpieceShapeEnum.DVDFlatRateBox:
                case MailpieceShapeEnum.Letter:
                    return false;
                default:
                    return false;
            }
        }
        internal static bool IsInternationalPiece(MailpieceShapeEnum mailPiece)
        {
            switch (mailPiece)
            {
                case MailpieceShapeEnum.IrregularParcel:
                case MailpieceShapeEnum.LargeFlatRateBox:
                case MailpieceShapeEnum.LargeParcel:
                case MailpieceShapeEnum.LargeVideoFlatRateBox:
                case MailpieceShapeEnum.MediumFlatRateBox:
                case MailpieceShapeEnum.OversizedParcel:
                case MailpieceShapeEnum.Parcel:
                case MailpieceShapeEnum.SmallFlatRateBox:
                    return true;

                case MailpieceShapeEnum.Card:
                case MailpieceShapeEnum.DVDFlatRateBox:
                case MailpieceShapeEnum.Flat:
                case MailpieceShapeEnum.FlatRateCardboardEnvelope:
                case MailpieceShapeEnum.FlatRateEnvelope:
                case MailpieceShapeEnum.FlatRateGiftCardEnvelope:
                case MailpieceShapeEnum.FlatRateLegalEnvelope:
                case MailpieceShapeEnum.FlatRatePaddedEnvelope:
                case MailpieceShapeEnum.FlatRateWindowEnvelope:
                case MailpieceShapeEnum.Letter:
                case MailpieceShapeEnum.SmallFlatRateEnvelope:
                    return false;

                default:
                    return false;
            }
        }
        #endregion
    }
}
