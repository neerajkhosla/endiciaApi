using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class ChangePassPhraseResponse : IChangePassPhraseResponse
	{
		public TransactionResultEnum ChangeStatus
		{
			get
			{
				return JustDecompileGenerated_get_ChangeStatus();
			}
			set
			{
				JustDecompileGenerated_set_ChangeStatus(value);
			}
		}

		private TransactionResultEnum JustDecompileGenerated_ChangeStatus_k__BackingField;

		public TransactionResultEnum JustDecompileGenerated_get_ChangeStatus()
		{
			return this.JustDecompileGenerated_ChangeStatus_k__BackingField;
		}

		public void JustDecompileGenerated_set_ChangeStatus(TransactionResultEnum value)
		{
			this.JustDecompileGenerated_ChangeStatus_k__BackingField = value;
		}

		public ChangePassPhraseResponse()
		{
		}
	}
}