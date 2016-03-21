using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    internal class PostageRatesClass
    {
        internal PostageRatesClass()
        {
        }

        #region Fields
        #endregion

        private IPostageRatesRequest GetPostageRatesRequest(string accountID, string passPhrase, string fromPostalCode, double OrderValueForInsurance,
            decimal packageHeight, decimal packageWidth, decimal packageLength, decimal packageWeight,
            string address1, string address2, string city, string country, string company, string twoLetterCountryCode, string email,
            string name, string phone, string zipPostalCode, string state, bool isInternational, bool isInsuredMail)
        {
            PostageRatesRequest result = new PostageRatesRequest();
            result.AccountID = accountID;
            result.PassPhrase = passPhrase;
            result.FromPostalCode = fromPostalCode;
            result.OrderValueForInsurance = 0;
            result.PackageDetails = new PackageDetails(packageHeight, packageWidth, packageLength, packageWeight);
            result.TargetAddress = new AddressDetails()
            {
                Address1 = address1,
                Address2 = address2,
                City = city,
                Country = country,
                Company = company,
                CountryCode = twoLetterCountryCode,
                Email = email,
                Name = name,
                Phone = phone,
                PostalCode = zipPostalCode,
                State = state
            };

            if (isInternational)
            {
                result.DeliveryConfirmation = false;
                result.InsuredMail = TSI.Utils.Shipping.Endicia.Enums.InsuredMailEnum.OFF;
                result.SignatureConfirmation = false;
                result.MailClass = LabelTypeEnum.International;
            }
            else
            {
                result.DeliveryConfirmation = false;
                result.SignatureConfirmation = false;
                result.InsuredMail = isInsuredMail ? InsuredMailEnum.Endicia : InsuredMailEnum.OFF;
                result.MailClass = LabelTypeEnum.Domestic;
            }
            return result;

        }
        internal IPostageRatesResponse GetPostageRatesResponse(string accountID, string passPhrase, string fromPostalCode, double OrderValueForInsurance,
            decimal packageHeight, decimal packageWidth, decimal packageLength, decimal packageWeight,
            string address1, string address2, string city, string country, string company, string twoLetterCountryCode, string email,
            string name, string phone, string zipPostalCode, string state, bool isInternational, bool isInsuredMail)
        {
            try
            {
                IPostageRatesRequest request = GetPostageRatesRequest(accountID, passPhrase, fromPostalCode, OrderValueForInsurance,
            packageHeight, packageWidth, packageLength, packageWeight,
            address1, address2, city, country, company, twoLetterCountryCode, email,
            name, phone, zipPostalCode, state, isInternational, isInsuredMail);
                return Invoker.GetPostageRates(request);
            }
            catch (Exception)
            {
                // Log
                return null;
            }
        }
    }

    internal class PostageRatesRequest : IPostageRatesRequest
    {

        public string AccountID { get; set; }
        public bool DeliveryConfirmation { get; set; }
        public string FromPostalCode { get; set; }

        public TSI.Utils.Shipping.Endicia.Enums.InsuredMailEnum InsuredMail { get; set; }

        public TSI.Utils.Shipping.Endicia.Enums.LabelTypeEnum MailClass { get; set; }

        public double OrderValueForInsurance { get; set; }

        public IPackageDetails PackageDetails { get; set; }

        public string PassPhrase { get; set; }

        public bool SignatureConfirmation { get; set; }

        public IAddressDetails TargetAddress { get; set; }

    }
}
