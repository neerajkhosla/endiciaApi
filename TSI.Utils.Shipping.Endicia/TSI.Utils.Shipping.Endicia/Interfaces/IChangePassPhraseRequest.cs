using System;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IChangePassPhraseRequest
	{
		string AccountID
		{
			get;
		}

		string CurrentPassPhrase
		{
			get;
		}

		string NewPassPhrase
		{
			get;
		}
	}
}