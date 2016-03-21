using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia.Enums;

namespace Endicia.Api
{
    public delegate List<USPSShippingMethod> GetShippingMethodsList();

    public class USPSShippingMethod
    {
        public USPSShippingMethod()
        {
        }

        public USPSShippingMethod(MailClassEnum val)
        {
            this.MailClass = val;
            this.Name = ShippingMethodManager.GetMailClassName(val);
        }

        public USPSShippingMethod(string key)
        {
            MailClass = (MailClassEnum)Enum.Parse(typeof(MailClassEnum), key, true);
            Name = ShippingMethodManager.GetMailClassName(this.MailClass);
        }

        public MailClassEnum MailClass { get; internal set; }
        public string Name { get; internal set; }
        public override string ToString()
        {
            return ((int)MailClass).ToString();
        }
    }

    public static class ShippingMethodManager
    {
        public static List<USPSShippingMethod> GetDomesticShippingMethods()
        {
            List<USPSShippingMethod> result = new List<USPSShippingMethod>();
            //result.Add(new USPSShippingMethod(MailClassEnum.ExpressMail));
            result.Add(new USPSShippingMethod(MailClassEnum.PriorityMail));
            result.Add(new USPSShippingMethod(MailClassEnum.FirstClassMail));
            result.Add(new USPSShippingMethod(MailClassEnum.LibraryMail));
            result.Add(new USPSShippingMethod(MailClassEnum.MediaMail));
            result.Add(new USPSShippingMethod(MailClassEnum.StandardPost));

            return result;
        }
        public static List<USPSShippingMethod> GetInternationalShippingMethods()
        {
            List<USPSShippingMethod> result = new List<USPSShippingMethod>();
            result.Add(new USPSShippingMethod(MailClassEnum.ExpressMailInternational));
            result.Add(new USPSShippingMethod(MailClassEnum.PriorityMailInternational));
            result.Add(new USPSShippingMethod(MailClassEnum.FirstClassMailInternational));

            return result;

        }
        public static string GetShippingMethodKeys(List<USPSShippingMethod> methods)
        {
            string result = "_";
            foreach (USPSShippingMethod method in methods)
            {
                result += method.ToString() + "_";
            }

            return result;
        }
        public static List<USPSShippingMethod> GetShippingMethodsFromKeys(string keys)
        {
            if (String.IsNullOrEmpty(keys)) return new List<USPSShippingMethod>();

            return (from string key in keys.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries)
                    select new USPSShippingMethod(key)).ToList<USPSShippingMethod>();
        }
        internal static string GetMailClassName(MailClassEnum mailClass)
        {
            switch (mailClass)
            {
                //case MailClassEnum.ExpressMail:
                //    return "Express Mail®";

                case MailClassEnum.FirstClassMail:
                    return "First-Class Mail®";

                case MailClassEnum.LibraryMail:
                    return "Library Mail®";

                case MailClassEnum.MediaMail:
                    return "Media Mail®";

                //case MailClassEnum.ParcelPost:
                //    return "Parcel Post®";
                case MailClassEnum.ParcelSelect:
                    return "Parcel Select®";

                case MailClassEnum.PriorityMail:
                    return "Priority Mail®";

                case MailClassEnum.CriticalMail:
                    return "Critical Mail®";

                case MailClassEnum.StandardPost:
                    return "Standard Post®";

                case MailClassEnum.ExpressMailInternational:
                    return "Express Mail International®";

                case MailClassEnum.FirstClassMailInternational:
                    return "First-Class Mail International®";

                case MailClassEnum.PriorityMailInternational:
                    return "Priority Mail International®";

                default:
                    return String.Empty;

            }

        }

    }
}
