using System;
using TSI.Utils.Shipping.Endicia.Properties;

namespace TSI.Utils.Shipping.Endicia
{
	internal class ConfigManager
	{
		private static ConfigManager _instance;

		internal static ConfigManager Current
		{
			get
			{
				if (ConfigManager._instance == null)
				{
					ConfigManager._instance = new ConfigManager();
				}
				return ConfigManager._instance;
			}
		}

		internal string DefaultAdultSignature
		{
			get
			{
				return Settings.Default.DefaultAdultSignature;
			}
		}

		internal string DefaultAdultSignatureRestrictedDelivery
		{
			get
			{
				return Settings.Default.DefaultAdultSignatureRestrictedDelivery;
			}
		}

		internal string DefaultAutomationRate
		{
			get
			{
				return bool.FalseString;
			}
		}

		internal string DefaultCertifiedMail
		{
			get
			{
				return Settings.Default.DefaultCertifiedMail;
			}
		}

		internal string DefaultCOD
		{
			get
			{
				return "OFF";
			}
		}

		internal string DefaultCustomsCertify
		{
			get
			{
				return Settings.Default.DefaultCustomsCertify;
			}
		}

		internal int DefaultDateAdvance
		{
			get
			{
				return Settings.Default.DefaultDateAdvance;
			}
		}

		internal string DefaultDomesticLabelSubType
		{
			get
			{
				return Settings.Default.DefaultDomesticLabelSubType;
			}
		}

		internal string DefaultElectornicReturnReceipt
		{
			get
			{
				return "OFF";
			}
		}

		internal string DefaultEntryFacility
		{
			get
			{
				return "Other";
			}
		}

		internal string DefaultHoldForPickup
		{
			get
			{
				return "OFF";
			}
		}

		internal string DefaultImageFormat
		{
			get
			{
				return Settings.Default.DefaultImageFormat;
			}
		}

		internal string DefaultInternationalLabelSubType
		{
			get
			{
				return Settings.Default.DefaultInternationalLabelSubType;
			}
		}

		internal string DefaultMachinable
		{
			get
			{
				return "TRUE";
			}
		}

		internal string DefaultMerchandise
		{
			get
			{
				return Settings.Default.DefaultMerchandise;
			}
		}

		internal string DefaultNonDeliveryOption
		{
			get
			{
				return Settings.Default.DefaultNonDeliveryOption;
			}
		}

		internal string DefaultNoWeekendDelivery
		{
			get
			{
				return Settings.Default.DefaultNoWeekendDelivery;
			}
		}

		internal string DefaultOpenAndDistribute
		{
			get
			{
				return "OFF";
			}
		}

		internal string DefaultPackageTypeIndicator
		{
			get
			{
				return null;
			}
		}

		internal string DefaultPricing
		{
			get
			{
				return Settings.Default.DefaultPricing;
			}
		}

		internal string DefaultReplayPostage
		{
			get
			{
				return Settings.Default.DefaultReplayPostage;
			}
		}

		internal string DefaultResponseOptions
		{
			get
			{
				return Settings.Default.DefaultResponseOptions;
			}
		}

		internal string DefaultRestrictedDelivery
		{
			get
			{
				return Settings.Default.DefaultRestrictedDelivery;
			}
		}

		internal string DefaultRestrictionType
		{
			get
			{
				return Settings.Default.DefaultRestrictionType;
			}
		}

		internal string DefaultReturnReceipt
		{
			get
			{
				return Settings.Default.DefaultReturnReceipt;
			}
		}

		internal string DefaultServiceLevel
		{
			get
			{
				return Settings.Default.DefaultServiceLevel;
			}
		}

		internal string DefaultShowReturnAddress
		{
			get
			{
				return Settings.Default.DefaultShowReturnAddress;
			}
		}

		internal string DefaultSignatureWaiver
		{
			get
			{
				return Settings.Default.DefaultSignatureWaiver;
			}
		}

		internal string DefaultSundayHolidayDelivery
		{
			get
			{
				return Settings.Default.DefaultSundayHolidayDelivery;
			}
		}

		public ConfigManager()
		{
		}
	}
}