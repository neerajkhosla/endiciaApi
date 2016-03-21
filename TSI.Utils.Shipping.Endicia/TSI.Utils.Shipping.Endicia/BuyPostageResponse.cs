using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	public class BuyPostageResponse : IBuyPostageResponse, IAccountStatusResponse
	{
		public decimal AccountBalanceUSD
		{
			get
			{
				return JustDecompileGenerated_get_AccountBalanceUSD();
			}
			set
			{
				JustDecompileGenerated_set_AccountBalanceUSD(value);
			}
		}

		private decimal JustDecompileGenerated_AccountBalanceUSD_k__BackingField;

		public decimal JustDecompileGenerated_get_AccountBalanceUSD()
		{
			return this.JustDecompileGenerated_AccountBalanceUSD_k__BackingField;
		}

		public void JustDecompileGenerated_set_AccountBalanceUSD(decimal value)
		{
			this.JustDecompileGenerated_AccountBalanceUSD_k__BackingField = value;
		}

		public AccountStatusEnum AccountStatus
		{
			get
			{
				return JustDecompileGenerated_get_AccountStatus();
			}
			set
			{
				JustDecompileGenerated_set_AccountStatus(value);
			}
		}

		private AccountStatusEnum JustDecompileGenerated_AccountStatus_k__BackingField;

		public AccountStatusEnum JustDecompileGenerated_get_AccountStatus()
		{
			return this.JustDecompileGenerated_AccountStatus_k__BackingField;
		}

		public void JustDecompileGenerated_set_AccountStatus(AccountStatusEnum value)
		{
			this.JustDecompileGenerated_AccountStatus_k__BackingField = value;
		}

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

		public TransactionResultEnum RecreditStatus
		{
			get
			{
				return JustDecompileGenerated_get_RecreditStatus();
			}
			set
			{
				JustDecompileGenerated_set_RecreditStatus(value);
			}
		}

		private TransactionResultEnum JustDecompileGenerated_RecreditStatus_k__BackingField;

		public TransactionResultEnum JustDecompileGenerated_get_RecreditStatus()
		{
			return this.JustDecompileGenerated_RecreditStatus_k__BackingField;
		}

		public void JustDecompileGenerated_set_RecreditStatus(TransactionResultEnum value)
		{
			this.JustDecompileGenerated_RecreditStatus_k__BackingField = value;
		}

		public BuyPostageResponse()
		{
		}
	}
}