using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class PostagePrice : IPostagePrice
	{
		public IFees Fees
		{
			get
			{
				return JustDecompileGenerated_get_Fees();
			}
			set
			{
				JustDecompileGenerated_set_Fees(value);
			}
		}

		private IFees JustDecompileGenerated_Fees_k__BackingField;

		public IFees JustDecompileGenerated_get_Fees()
		{
			return this.JustDecompileGenerated_Fees_k__BackingField;
		}

		public void JustDecompileGenerated_set_Fees(IFees value)
		{
			this.JustDecompileGenerated_Fees_k__BackingField = value;
		}

		public MailClassEnum MailClass
		{
			get
			{
				return JustDecompileGenerated_get_MailClass();
			}
			set
			{
				JustDecompileGenerated_set_MailClass(value);
			}
		}

		private MailClassEnum JustDecompileGenerated_MailClass_k__BackingField;

		public MailClassEnum JustDecompileGenerated_get_MailClass()
		{
			return this.JustDecompileGenerated_MailClass_k__BackingField;
		}

		public void JustDecompileGenerated_set_MailClass(MailClassEnum value)
		{
			this.JustDecompileGenerated_MailClass_k__BackingField = value;
		}

		public string MailService
		{
			get
			{
				return JustDecompileGenerated_get_MailService();
			}
			set
			{
				JustDecompileGenerated_set_MailService(value);
			}
		}

		private string JustDecompileGenerated_MailService_k__BackingField;

		public string JustDecompileGenerated_get_MailService()
		{
			return this.JustDecompileGenerated_MailService_k__BackingField;
		}

		public void JustDecompileGenerated_set_MailService(string value)
		{
			this.JustDecompileGenerated_MailService_k__BackingField = value;
		}

		public string Pricing
		{
			get
			{
				return JustDecompileGenerated_get_Pricing();
			}
			set
			{
				JustDecompileGenerated_set_Pricing(value);
			}
		}

		private string JustDecompileGenerated_Pricing_k__BackingField;

		public string JustDecompileGenerated_get_Pricing()
		{
			return this.JustDecompileGenerated_Pricing_k__BackingField;
		}

		public void JustDecompileGenerated_set_Pricing(string value)
		{
			this.JustDecompileGenerated_Pricing_k__BackingField = value;
		}

		public decimal TotalAmount
		{
			get
			{
				return JustDecompileGenerated_get_TotalAmount();
			}
			set
			{
				JustDecompileGenerated_set_TotalAmount(value);
			}
		}

		private decimal JustDecompileGenerated_TotalAmount_k__BackingField;

		public decimal JustDecompileGenerated_get_TotalAmount()
		{
			return this.JustDecompileGenerated_TotalAmount_k__BackingField;
		}

		public void JustDecompileGenerated_set_TotalAmount(decimal value)
		{
			this.JustDecompileGenerated_TotalAmount_k__BackingField = value;
		}

		public string Zone
		{
			get
			{
				return JustDecompileGenerated_get_Zone();
			}
			set
			{
				JustDecompileGenerated_set_Zone(value);
			}
		}

		private string JustDecompileGenerated_Zone_k__BackingField;

		public string JustDecompileGenerated_get_Zone()
		{
			return this.JustDecompileGenerated_Zone_k__BackingField;
		}

		public void JustDecompileGenerated_set_Zone(string value)
		{
			this.JustDecompileGenerated_Zone_k__BackingField = value;
		}

		public PostagePrice()
		{
		}
	}
}