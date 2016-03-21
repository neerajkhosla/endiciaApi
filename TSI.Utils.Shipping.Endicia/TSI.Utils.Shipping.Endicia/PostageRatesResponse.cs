using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class PostageRatesResponse : IPostageRatesResponse
	{
		public string ErrorMessage
		{
			get
			{
				return JustDecompileGenerated_get_ErrorMessage();
			}
			set
			{
				JustDecompileGenerated_set_ErrorMessage(value);
			}
		}

		private string JustDecompileGenerated_ErrorMessage_k__BackingField;

		public string JustDecompileGenerated_get_ErrorMessage()
		{
			return this.JustDecompileGenerated_ErrorMessage_k__BackingField;
		}

		public void JustDecompileGenerated_set_ErrorMessage(string value)
		{
			this.JustDecompileGenerated_ErrorMessage_k__BackingField = value;
		}

		public IList<IPostagePrice> Postages
		{
			get
			{
				return JustDecompileGenerated_get_Postages();
			}
			set
			{
				JustDecompileGenerated_set_Postages(value);
			}
		}

		private IList<IPostagePrice> JustDecompileGenerated_Postages_k__BackingField;

		public IList<IPostagePrice> JustDecompileGenerated_get_Postages()
		{
			return this.JustDecompileGenerated_Postages_k__BackingField;
		}

		public void JustDecompileGenerated_set_Postages(IList<IPostagePrice> value)
		{
			this.JustDecompileGenerated_Postages_k__BackingField = value;
		}

		public TransactionResultEnum Status
		{
			get
			{
				return JustDecompileGenerated_get_Status();
			}
			set
			{
				JustDecompileGenerated_set_Status(value);
			}
		}

		private TransactionResultEnum JustDecompileGenerated_Status_k__BackingField;

		public TransactionResultEnum JustDecompileGenerated_get_Status()
		{
			return this.JustDecompileGenerated_Status_k__BackingField;
		}

		public void JustDecompileGenerated_set_Status(TransactionResultEnum value)
		{
			this.JustDecompileGenerated_Status_k__BackingField = value;
		}

		public PostageRatesResponse()
		{
		}
	}
}