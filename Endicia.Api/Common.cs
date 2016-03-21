using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace Endicia.Api
{
    public class PackageDetails : IPackageDetails
    {

        public PackageDetails(decimal height, decimal length, decimal width, decimal weight)
        {
            //var usedMeasureWeight = measureService.GetMeasureWeightBySystemKeyword("ounce");
            ////weight is in ounce

            //var baseusedMeasureWeight = measureService.GetMeasureWeightById(measureSettings.BaseWeightId);
            //if (baseusedMeasureWeight == null)
            //    throw new NopException("Primary weight can't be loaded");

            //var usedMeasureDimension = measureService.GetMeasureDimensionBySystemKeyword("inches");
            //if (usedMeasureDimension == null)
            //    throw new NopException(string.Format("Endicia (USPS) shipping service. Could not load \"{0}\" measure dimension", "inches"));

            //var baseusedMeasureDimension = measureService.GetMeasureWeightById(measureSettings.BaseDimensionId);
            //if (usedMeasureDimension == null)
            //    throw new NopException("Primary dimension can't be loaded");


            //this.Length = Convert.ToInt32(Math.Ceiling(length / baseusedMeasureDimension.Ratio * usedMeasureDimension.Ratio));
            //this.Height = Convert.ToInt32(Math.Ceiling(height / baseusedMeasureDimension.Ratio * usedMeasureDimension.Ratio));
            //this.Width = Convert.ToInt32(Math.Ceiling(width / baseusedMeasureDimension.Ratio * usedMeasureDimension.Ratio));
            //this.WeightOz = Convert.ToInt32(Math.Ceiling(weight / baseusedMeasureWeight.Ratio * usedMeasureWeight.Ratio));

            if (this.Length < 1) this.Length = 1;
            if (this.Height < 1) this.Height = 1;
            if (this.Width < 1) this.Width = 1;
            if (this.WeightOz < 1) this.WeightOz = 1;

            Items = new List<IPackageItem>();
        }

        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double WeightOz { get; set; }

        public MailpieceShapeEnum MailPieceShape { get; set; }



        public List<IPackageItem> Items { get; set; }
    }
    public class PackageItem : IPackageItem
    {

        public string CustomCountry { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public int WeightOz { get; set; }
    }
    public class AddressDetails : IAddressDetails
    {

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
    }
}
