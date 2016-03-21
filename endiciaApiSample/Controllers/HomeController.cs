using Endicia.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace endiciaApiSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //change pass phrase
            //ChangePassPhraseClass.ChangePassPhrase("2505633", "devs neeraj", "hello endicia");



            string accountId = "2505633";
            int costCenter = 123;
            bool includePostage = false;
            int orderId = 12345;
            string passPhrase = "hello endicia";
            string physicalPathToSave = "F:\\Transfer_20150830\\Study\\endicia-nopcommerce\\endiciaAPI\\endiciaApiSample\\endiciaApiSample\\Labels\\";
            string postOfficeZipCode = "90807";
            bool printSandBox = true;
            string rubberStamp = "";
            string virtualPath = "~/Labels/";
            decimal orderValueForInsurance = 0;
            int transactionId = 1221;
            DateTime shipDateTime = DateTime.Now;
            string mailClassId = "2";
            string labelSizeId = "1";
            string customSigner = "";
            string customCertificateNumber = "";
            string invoiceNumber = "123321";

            AddressDetails senderAddress = new AddressDetails()
                {
                    Address1 = "4300",
                    Address2 = "Long Beach Blvd",
                    City = "Long Beach",
                    Company = String.Empty,
                    CountryCode = "US",
                    Email = "devs.neeraj@gmail.com",
                    Name = "Neeraj",
                    Phone = "5628521598",
                    PostalCode = "90807",
                    State = "CA"
                };

            AddressDetails targetAddress = new AddressDetails()
                {
                    Address1 = "2691",
                    Address2 = "Pasadena Ave",
                    City = "Long Beach",
                    Company = "",
                    Email = "meet.best@gmail.com",
                    Name = "Neeraj 2",
                    Phone = "5628521597",
                    State = "CA",
                    PostalCode = "90806",
                    Country = "USA",
                    CountryCode = "US", //two letter iso code
                };

            PackageDetails packageDetails = new PackageDetails(1,1,1,12);
            packageDetails.MailPieceShape = MailpieceShapeEnum.Flat;

            PackageItem item = new PackageItem()
            {
                CustomCountry = "",
                Description = "Test item",
                Quantity = 2,
                Value = 1200,
                WeightOz = 12
            };
            packageDetails.Items.Add(item);

            LabelRequestRequest request = LoadPrintDataToModel(accountId, costCenter, includePostage, orderId, passPhrase, physicalPathToSave, postOfficeZipCode, 
                printSandBox, rubberStamp, virtualPath, senderAddress, targetAddress, orderValueForInsurance, transactionId, shipDateTime, mailClassId,
                labelSizeId, customSigner, customCertificateNumber, invoiceNumber, packageDetails);
            
            
           ILabelRequestResponse response = PrintLabelClass.PrintLabel(request);
            if (response.Status == TransactionResultEnum.Succeed)
            {

            }
            return View();
        }
        private LabelRequestRequest LoadPrintDataToModel(string accountId, int costCenter, bool includePostage, int orderId, string passPhrase, string physicalPathToSave,
            string postOfficeZipCode, bool printSandBox, string rubberStamp, string virtualPath, AddressDetails senderAddress, AddressDetails targetAddress,
            decimal orderValueForInsurance, int transactionId, DateTime shipDateTime, string mailClassId, string labelSizeId, string customSigner,
            string customCertificateNumber, string invoiceNumber, PackageDetails packageDetails)
        {
            LabelRequestRequest request = new LabelRequestRequest()
            {
                AccountID = accountId,
                CostCetner = costCenter,
                IncludePostage = includePostage,
                OrderId = orderId,
                PassPhrase = passPhrase,
                PhyisicalPathToSave = physicalPathToSave,
                PoZipCode = postOfficeZipCode,
                PrintSandbox = printSandBox,
                RubberStamp = rubberStamp,
                VirtualPath = virtualPath,
                SenderDetails = senderAddress,
                TargetAddress = targetAddress,
                OrderValueForInsurance = "0",
                TransactionId = 12345,
                ShipDateTime = DateTime.Now,
                MailClass = (MailClassEnum)Enum.Parse(typeof(MailClassEnum), mailClassId),
                LabelSize = (LabelSizeEnum)Enum.Parse(typeof(LabelSizeEnum), labelSizeId),
                CustomSigner = customSigner,
                CustomCertificateNumber = customCertificateNumber,
                InvoiceNumber = invoiceNumber,
            };
            request.MailPieceShape = MailpieceShapeEnum.Flat;
            request.PackageDetails = packageDetails;
            request.LabelType = LabelTypeEnum.Default;
            return request;
        }
    }
}