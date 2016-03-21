using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endicia.Api
{
    public static class ShippingHelper
    {
        public static bool IsInternationalShipping(GetShippingOptionRequest getShippingOptionRequest)
        {
            //Origin Country must be USA, Collect USA from list of countries
            bool result = false;
            if (getShippingOptionRequest != null &&
                getShippingOptionRequest.ShippingAddress != null &&
                getShippingOptionRequest.ShippingAddress.Country != null)
            {
                result = getShippingOptionRequest.ShippingAddress.Country.ThreeLetterIsoCode != "USA";
            }
            return result;
        }

        public static string GetFromPostalCode(IAddressService _addressService, ShippingSettings _shippingSettings, GetShippingOptionRequest getShippingOptionRequest)
        {
            if (String.IsNullOrEmpty(getShippingOptionRequest.ZipPostalCodeFrom))
            {
                return _addressService.GetAddressById(_shippingSettings.ShippingOriginAddressId).ZipPostalCode;
            }
            else
                return getShippingOptionRequest.ZipPostalCodeFrom;

        }

        internal static bool IsDomesticShipping(string sourceCountry, string destinationCountry)
        {
            return (sourceCountry == "US" && sourceCountry == destinationCountry);
        }

        internal static PackageDetails GetPackageDetails(Services.Directory.IMeasureService measureService, Core.Domain.Directory.MeasureSettings measureSettings, string storeCountry, Core.Domain.Orders.Order order, int overrideWeight = 0)
        {
            decimal height = 0;
            decimal length = 0;
            decimal width = 0;
            decimal weight = 0;
            var usedMeasureWeight = measureService.GetMeasureWeightBySystemKeyword("ounce");
            var baseusedMeasureWeight = measureService.GetMeasureWeightById(measureSettings.BaseWeightId);
            List<IPackageItem> items = new List<IPackageItem>();

            foreach (OrderItem item in order.OrderItems)
            {
                if (item.Product.IsShipEnabled)
                {
                    height += (item.Product.Height * item.Quantity);
                    width += (item.Product.Width * item.Quantity);
                    length += item.Product.Length;
                    weight += (item.Product.Weight * item.Quantity);

                    PackageItem packageItem = new PackageItem();
                    packageItem.CustomCountry = storeCountry;
                    packageItem.Description = item.Product.Name ?? String.Empty;
                    packageItem.Quantity = item.Quantity;
                    packageItem.Value = item.PriceInclTax;
                    packageItem.WeightOz = Convert.ToInt32(Math.Ceiling(item.Product.Weight / baseusedMeasureWeight.Ratio * usedMeasureWeight.Ratio));
                    items.Add(packageItem);
                }

            }

            PackageDetails packageDetails = new PackageDetails(measureService, measureSettings, height, length, width, weight);

            if (overrideWeight != 0)
                packageDetails.WeightOz = overrideWeight;

            packageDetails.Items = items;
            return packageDetails;
        }
    }
}
