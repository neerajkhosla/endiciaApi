using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class AccountStatusResponse : IAccountStatusResponse
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

		public AccountStatusResponse()
		{
		}
	}
}