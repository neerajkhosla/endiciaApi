using System;
using System.Runtime.CompilerServices;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	internal class LabelData : ILabel
	{
		public string FileOnly
		{
			get
			{
				return JustDecompileGenerated_get_FileOnly();
			}
			set
			{
				JustDecompileGenerated_set_FileOnly(value);
			}
		}

		private string JustDecompileGenerated_FileOnly_k__BackingField;

		public string JustDecompileGenerated_get_FileOnly()
		{
			return this.JustDecompileGenerated_FileOnly_k__BackingField;
		}

		public void JustDecompileGenerated_set_FileOnly(string value)
		{
			this.JustDecompileGenerated_FileOnly_k__BackingField = value;
		}

		public string FullPathFileName
		{
			get
			{
				return JustDecompileGenerated_get_FullPathFileName();
			}
			set
			{
				JustDecompileGenerated_set_FullPathFileName(value);
			}
		}

		private string JustDecompileGenerated_FullPathFileName_k__BackingField;

		public string JustDecompileGenerated_get_FullPathFileName()
		{
			return this.JustDecompileGenerated_FullPathFileName_k__BackingField;
		}

		public void JustDecompileGenerated_set_FullPathFileName(string value)
		{
			this.JustDecompileGenerated_FullPathFileName_k__BackingField = value;
		}

		public string Link
		{
			get
			{
				return JustDecompileGenerated_get_Link();
			}
			set
			{
				JustDecompileGenerated_set_Link(value);
			}
		}

		private string JustDecompileGenerated_Link_k__BackingField;

		public string JustDecompileGenerated_get_Link()
		{
			return this.JustDecompileGenerated_Link_k__BackingField;
		}

		public void JustDecompileGenerated_set_Link(string value)
		{
			this.JustDecompileGenerated_Link_k__BackingField = value;
		}

		public LabelData()
		{
		}
	}
}