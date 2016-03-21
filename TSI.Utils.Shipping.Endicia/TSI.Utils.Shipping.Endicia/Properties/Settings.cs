using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TSI.Utils.Shipping.Endicia.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("OFF")]
		public string DefaultAdultSignature
		{
			get
			{
				return (string)this["DefaultAdultSignature"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("OFF")]
		public string DefaultAdultSignatureRestrictedDelivery
		{
			get
			{
				return (string)this["DefaultAdultSignatureRestrictedDelivery"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("OFF")]
		public string DefaultCertifiedMail
		{
			get
			{
				return (string)this["DefaultCertifiedMail"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("TRUE")]
		public string DefaultCustomsCertify
		{
			get
			{
				return (string)this["DefaultCustomsCertify"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int DefaultDateAdvance
		{
			get
			{
				return (int)this["DefaultDateAdvance"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("None")]
		public string DefaultDomesticLabelSubType
		{
			get
			{
				return (string)this["DefaultDomesticLabelSubType"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("PNG")]
		public string DefaultImageFormat
		{
			get
			{
				return (string)this["DefaultImageFormat"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Integrated")]
		public string DefaultInternationalLabelSubType
		{
			get
			{
				return (string)this["DefaultInternationalLabelSubType"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Merchandise")]
		public string DefaultMerchandise
		{
			get
			{
				return (string)this["DefaultMerchandise"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Return")]
		public string DefaultNonDeliveryOption
		{
			get
			{
				return (string)this["DefaultNonDeliveryOption"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("TRUE")]
		public string DefaultNoWeekendDelivery
		{
			get
			{
				return (string)this["DefaultNoWeekendDelivery"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Null")]
		public string DefaultPackageTypeIndicator
		{
			get
			{
				return (string)this["DefaultPackageTypeIndicator"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Retail")]
		public string DefaultPricing
		{
			get
			{
				return (string)this["DefaultPricing"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("FALSE")]
		public string DefaultReplayPostage
		{
			get
			{
				return (string)this["DefaultReplayPostage"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("TRUE")]
		public string DefaultResponseOptions
		{
			get
			{
				return (string)this["DefaultResponseOptions"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("OFF")]
		public string DefaultRestrictedDelivery
		{
			get
			{
				return (string)this["DefaultRestrictedDelivery"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("None")]
		public string DefaultRestrictionType
		{
			get
			{
				return (string)this["DefaultRestrictionType"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("OFF")]
		public string DefaultReturnReceipt
		{
			get
			{
				return (string)this["DefaultReturnReceipt"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DefaultServiceLevel
		{
			get
			{
				return (string)this["DefaultServiceLevel"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("TRUE")]
		public string DefaultShowReturnAddress
		{
			get
			{
				return (string)this["DefaultShowReturnAddress"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("TRUE")]
		public string DefaultSignatureWaiver
		{
			get
			{
				return (string)this["DefaultSignatureWaiver"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("FALSE")]
		public string DefaultSundayHolidayDelivery
		{
			get
			{
				return (string)this["DefaultSundayHolidayDelivery"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://labelserver.endicia.com/LabelService/EwsLabelService.asmx")]
		[SpecialSetting(SpecialSetting.WebServiceUrl)]
		public string TSI_Utils_Shipping_Endicia_EndiciaLabelService_EwsLabelService
		{
			get
			{
				return (string)this["TSI_Utils_Shipping_Endicia_EndiciaLabelService_EwsLabelService"];
			}
		}

		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}

		public Settings()
		{
		}
	}
}