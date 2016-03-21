using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class Fees : IFees
	{
		public decimal DeliveryConfirmation
		{
			get
			{
				return JustDecompileGenerated_get_DeliveryConfirmation();
			}
			set
			{
				JustDecompileGenerated_set_DeliveryConfirmation(value);
			}
		}

		private decimal JustDecompileGenerated_DeliveryConfirmation_k__BackingField;

		public decimal JustDecompileGenerated_get_DeliveryConfirmation()
		{
			return this.JustDecompileGenerated_DeliveryConfirmation_k__BackingField;
		}

		public void JustDecompileGenerated_set_DeliveryConfirmation(decimal value)
		{
			this.JustDecompileGenerated_DeliveryConfirmation_k__BackingField = value;
		}

		public decimal InsuredMail
		{
			get
			{
				return JustDecompileGenerated_get_InsuredMail();
			}
			set
			{
				JustDecompileGenerated_set_InsuredMail(value);
			}
		}

		private decimal JustDecompileGenerated_InsuredMail_k__BackingField;

		public decimal JustDecompileGenerated_get_InsuredMail()
		{
			return this.JustDecompileGenerated_InsuredMail_k__BackingField;
		}

		public void JustDecompileGenerated_set_InsuredMail(decimal value)
		{
			this.JustDecompileGenerated_InsuredMail_k__BackingField = value;
		}

		public decimal SignatureConfirmation
		{
			get
			{
				return JustDecompileGenerated_get_SignatureConfirmation();
			}
			set
			{
				JustDecompileGenerated_set_SignatureConfirmation(value);
			}
		}

		private decimal JustDecompileGenerated_SignatureConfirmation_k__BackingField;

		public decimal JustDecompileGenerated_get_SignatureConfirmation()
		{
			return this.JustDecompileGenerated_SignatureConfirmation_k__BackingField;
		}

		public void JustDecompileGenerated_set_SignatureConfirmation(decimal value)
		{
			this.JustDecompileGenerated_SignatureConfirmation_k__BackingField = value;
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

		public Fees()
		{
		}
	}
}