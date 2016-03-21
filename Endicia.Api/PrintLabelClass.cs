using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    public static class PrintLabelClass
    {
        public static ILabelRequestResponse PrintLabel(ILabelRequestRequest request)
        {

            try
            {
                return Invoker.PrintLabel(request);
            }
            catch (Exception ex)
            {
                // Log
                return null;
            }
        }
    }

    public class LabelRequestRequest : ILabelRequestRequest
    {
        public string AccountID { get; set; }
        public int CostCetner { get; set; }
        public bool DeliveryConfirmation { get; set; }
        public bool IncludePostage { get; set; }
        public TSI.Utils.Shipping.Endicia.Enums.InsuredMailEnum InsuredMail { get; set; }
        public TSI.Utils.Shipping.Endicia.Enums.LabelSizeEnum LabelSize { get; set; }
        public TSI.Utils.Shipping.Endicia.Enums.LabelTypeEnum LabelType { get; set; }
        public TSI.Utils.Shipping.Endicia.Enums.MailClassEnum MailClass { get; set; }
        public int OrderId { get; set; }
        public string OrderValueForInsurance { get; set; }
        public IPackageDetails PackageDetails { get; set; }
        public string PassPhrase { get; set; }
        public string PhyisicalPathToSave { get; set; }
        public string PoZipCode { get; set; }
        public bool PrintSandbox { get; set; }
        public string RubberStamp { get; set; }
        public IAddressDetails SenderDetails { get; set; }
        public DateTime ShipDateTime { get; set; }
        public bool SignatureConfirmation { get; set; }
        public IAddressDetails TargetAddress { get; set; }
        public int TransactionId { get; set; }
        public bool ValidateAddress { get; set; }
        public string VirtualPath { get; set; }
        public bool IsInternationalOrder { get; set; }


        public TSI.Utils.Shipping.Endicia.Enums.MailpieceShapeEnum MailPieceShape { get; set; }


        public string CustomCertificateNumber { get; set; }
        public string CustomSigner { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
