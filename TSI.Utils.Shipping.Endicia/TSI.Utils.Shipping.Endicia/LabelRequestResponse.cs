using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class LabelRequestResponse : ILabelRequestResponse
	{
		public int CostCenter
		{
			get
			{
				return JustDecompileGenerated_get_CostCenter();
			}
			set
			{
				JustDecompileGenerated_set_CostCenter(value);
			}
		}

		private int JustDecompileGenerated_CostCenter_k__BackingField;

		public int JustDecompileGenerated_get_CostCenter()
		{
			return this.JustDecompileGenerated_CostCenter_k__BackingField;
		}

		public void JustDecompileGenerated_set_CostCenter(int value)
		{
			this.JustDecompileGenerated_CostCenter_k__BackingField = value;
		}

		public List<ILabel> CustomForms
		{
			get
			{
				return JustDecompileGenerated_get_CustomForms();
			}
			set
			{
				JustDecompileGenerated_set_CustomForms(value);
			}
		}

		private List<ILabel> JustDecompileGenerated_CustomForms_k__BackingField;

		public List<ILabel> JustDecompileGenerated_get_CustomForms()
		{
			return this.JustDecompileGenerated_CustomForms_k__BackingField;
		}

		public void JustDecompileGenerated_set_CustomForms(List<ILabel> value)
		{
			this.JustDecompileGenerated_CustomForms_k__BackingField = value;
		}

		public string CustomNumber
		{
			get
			{
				return JustDecompileGenerated_get_CustomNumber();
			}
			set
			{
				JustDecompileGenerated_set_CustomNumber(value);
			}
		}

		private string JustDecompileGenerated_CustomNumber_k__BackingField;

		public string JustDecompileGenerated_get_CustomNumber()
		{
			return this.JustDecompileGenerated_CustomNumber_k__BackingField;
		}

		public void JustDecompileGenerated_set_CustomNumber(string value)
		{
			this.JustDecompileGenerated_CustomNumber_k__BackingField = value;
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

		public decimal FinalPostage
		{
			get
			{
				return JustDecompileGenerated_get_FinalPostage();
			}
			set
			{
				JustDecompileGenerated_set_FinalPostage(value);
			}
		}

		private decimal JustDecompileGenerated_FinalPostage_k__BackingField;

		public decimal JustDecompileGenerated_get_FinalPostage()
		{
			return this.JustDecompileGenerated_FinalPostage_k__BackingField;
		}

		public void JustDecompileGenerated_set_FinalPostage(decimal value)
		{
			this.JustDecompileGenerated_FinalPostage_k__BackingField = value;
		}

		public List<ILabel> Labels
		{
			get
			{
				return JustDecompileGenerated_get_Labels();
			}
			set
			{
				JustDecompileGenerated_set_Labels(value);
			}
		}

		private List<ILabel> JustDecompileGenerated_Labels_k__BackingField;

		public List<ILabel> JustDecompileGenerated_get_Labels()
		{
			return this.JustDecompileGenerated_Labels_k__BackingField;
		}

		public void JustDecompileGenerated_set_Labels(List<ILabel> value)
		{
			this.JustDecompileGenerated_Labels_k__BackingField = value;
		}

		public string PostmarkDate
		{
			get
			{
				return JustDecompileGenerated_get_PostmarkDate();
			}
			set
			{
				JustDecompileGenerated_set_PostmarkDate(value);
			}
		}

		private string JustDecompileGenerated_PostmarkDate_k__BackingField;

		public string JustDecompileGenerated_get_PostmarkDate()
		{
			return this.JustDecompileGenerated_PostmarkDate_k__BackingField;
		}

		public void JustDecompileGenerated_set_PostmarkDate(string value)
		{
			this.JustDecompileGenerated_PostmarkDate_k__BackingField = value;
		}

		public string ReferenceId
		{
			get
			{
				return JustDecompileGenerated_get_ReferenceId();
			}
			set
			{
				JustDecompileGenerated_set_ReferenceId(value);
			}
		}

		private string JustDecompileGenerated_ReferenceId_k__BackingField;

		public string JustDecompileGenerated_get_ReferenceId()
		{
			return this.JustDecompileGenerated_ReferenceId_k__BackingField;
		}

		public void JustDecompileGenerated_set_ReferenceId(string value)
		{
			this.JustDecompileGenerated_ReferenceId_k__BackingField = value;
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

		public string TrackingNumber
		{
			get
			{
				return JustDecompileGenerated_get_TrackingNumber();
			}
			set
			{
				JustDecompileGenerated_set_TrackingNumber(value);
			}
		}

		private string JustDecompileGenerated_TrackingNumber_k__BackingField;

		public string JustDecompileGenerated_get_TrackingNumber()
		{
			return this.JustDecompileGenerated_TrackingNumber_k__BackingField;
		}

		public void JustDecompileGenerated_set_TrackingNumber(string value)
		{
			this.JustDecompileGenerated_TrackingNumber_k__BackingField = value;
		}

		public int TransactionId
		{
			get
			{
				return JustDecompileGenerated_get_TransactionId();
			}
			set
			{
				JustDecompileGenerated_set_TransactionId(value);
			}
		}

		private int JustDecompileGenerated_TransactionId_k__BackingField;

		public int JustDecompileGenerated_get_TransactionId()
		{
			return this.JustDecompileGenerated_TransactionId_k__BackingField;
		}

		public void JustDecompileGenerated_set_TransactionId(int value)
		{
			this.JustDecompileGenerated_TransactionId_k__BackingField = value;
		}

		public LabelRequestResponse()
		{
		}
	}
}