using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSI.Utils.Shipping.Endicia.Enums;

namespace Endicia.Api
{
    public class LabelSizeClass
    {
        #region CTOR
        public LabelSizeClass(LabelSizeEnum labelSize)
        {
            this.LabelSize = labelSize;
            this.LabelSizeName = LabelSizeClass.GetLabelSizeName(labelSize);
            this.IsDomestic = LabelSizeClass.IsDomesticLabel(labelSize);
            this.IsInternational = LabelSizeClass.IsInternationalLabel(labelSize);
        }

        public LabelSizeClass(string labelSizeName)
        {
            this.LabelSizeName = labelSizeName;
            this.LabelSize = LabelSizeClass.GetLabelSizeEnum(labelSizeName);
            this.IsDomestic = LabelSizeClass.IsDomesticLabel(this.LabelSize);
            this.IsInternational = LabelSizeClass.IsInternationalLabel(this.LabelSize);
        }
        #endregion

        #region fileds
        public LabelSizeEnum LabelSize { get; set; }
        public string LabelSizeName { get; set; }
        public bool IsDomestic { get; set; }
        public bool IsInternational { get; set; }
        #endregion

        #region Static
        internal static string GetLabelSizeName(LabelSizeEnum labelSize)
        {
            switch (labelSize)
            {
                case LabelSizeEnum.Domestic_4x6:
                    return "4\" X 6\"";
                case LabelSizeEnum.InternationalDomestic_6X4:
                    return "6\" X 4\"";
                case LabelSizeEnum.International_85X533:
                    return "8.5\" X 5.33\"";
                case LabelSizeEnum._Default:
                    return "Default";
                default:
                    return String.Empty;
            }
        }
        internal static LabelSizeEnum GetLabelSizeEnum(string labelSizeName)
        {
            switch (labelSizeName)
            {
                case "":
                    return LabelSizeEnum._Default;
                case "4\" X 6\"":
                    return LabelSizeEnum.Domestic_4x6;
                case "8.5\" X 5.33\"":
                    return LabelSizeEnum.International_85X533;
                case "6\" X 4\"":
                    return LabelSizeEnum.InternationalDomestic_6X4;
                default:
                    return LabelSizeEnum._Default;

            }
        }
        internal static bool IsDomesticLabel(LabelSizeEnum labelSize)
        {
            switch (labelSize)
            {
                case LabelSizeEnum.Domestic_4x6:
                    return true;
                case LabelSizeEnum.InternationalDomestic_6X4:
                    return true;
                case LabelSizeEnum.International_85X533:
                    return false;
                case LabelSizeEnum._Default:
                    return true;
                default:
                    return false;
            }
        }
        internal static bool IsInternationalLabel(LabelSizeEnum labelSize)
        {
            switch (labelSize)
            {
                case LabelSizeEnum.Domestic_4x6:
                    return false;
                case LabelSizeEnum.InternationalDomestic_6X4:
                    return true;
                case LabelSizeEnum.International_85X533:
                    return true;
                case LabelSizeEnum._Default:
                    return true;
                default:
                    return false;
            }
        }
        #endregion
    }
}
