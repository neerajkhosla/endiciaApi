using System;
using System.Collections.Generic;
using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface ILabelRequestResponse
	{
		int CostCenter
		{
			get;
		}

		List<ILabel> CustomForms
		{
			get;
		}

		string CustomNumber
		{
			get;
		}

		string ErrorMessage
		{
			get;
		}

		decimal FinalPostage
		{
			get;
		}

		List<ILabel> Labels
		{
			get;
		}

		string PostmarkDate
		{
			get;
		}

		string ReferenceId
		{
			get;
		}

		TransactionResultEnum Status
		{
			get;
		}

		string TrackingNumber
		{
			get;
		}

		int TransactionId
		{
			get;
		}
	}
}