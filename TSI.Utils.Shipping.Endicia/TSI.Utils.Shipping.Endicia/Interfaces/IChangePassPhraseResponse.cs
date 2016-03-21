using TSI.Utils.Shipping.Endicia.Enums;

namespace TSI.Utils.Shipping.Endicia.Interfaces
{
	public interface IChangePassPhraseResponse
	{
		TransactionResultEnum ChangeStatus
		{
			get;
		}
	}
}