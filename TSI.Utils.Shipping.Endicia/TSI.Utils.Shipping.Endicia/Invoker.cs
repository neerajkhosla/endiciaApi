using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;
using TSI.Utils.Shipping.Endicia.EndiciaLabelService;
using TSI.Utils.Shipping.Endicia.Enums;
using TSI.Utils.Shipping.Endicia.Interfaces;

namespace TSI.Utils.Shipping.Endicia
{
	public static class Invoker
	{
		public static IBuyPostageResponse BuyPostage(IBuyPostageRequest request, ILogger logger = null)
		{
			string message;
			IBuyPostageResponse buyPostageResponse;
			try
			{
				EwsLabelService client = new EwsLabelService();
				buyPostageResponse = BuyPostageClass.ConstructBuyPostageResponse(client.BuyPostage(BuyPostageClass.ConstructBuyPostageRequest(request)));
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::BuyPostage Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::BuyPostage Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return buyPostageResponse;
		}

		public static IChangePassPhraseResponse ChangePassPhrase(IChangePassPhraseRequest request, ILogger logger = null)
		{
			string message;
			IChangePassPhraseResponse changePassPhraseResponse;
			try
			{
				EwsLabelService client = new EwsLabelService();
				changePassPhraseResponse = ChangePassPhraseClass.ConstructAccountStatusResponse(client.ChangePassPhrase(ChangePassPhraseClass.ConstructChangePassRequest(request)));
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::ChangePassPhrase Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::ChangePassPhrase Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return changePassPhraseResponse;
		}

		public static IAccountStatusResponse GetAccountStatus(IAccountStatusRequest request, ILogger logger = null)
		{
			string message;
			IAccountStatusResponse accountStatusResponse;
			try
			{
				EwsLabelService client = new EwsLabelService();
				accountStatusResponse = AccountStatusClass.ConstructAccountStatusResponse(client.GetAccountStatus(AccountStatusClass.ConstructAccountStatusRequest(request)));
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::GetAccountStatus Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::GetAccountStatus Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return accountStatusResponse;
		}

		public static IPostageRateResponse GetPostageRate(IPostageRateRequest request, ILogger logger = null)
		{
			string message;
			IPostageRateResponse postageRateResponse;
			try
			{
				EwsLabelService client = new EwsLabelService();
				postageRateResponse = PostageRateClass.ConstructPostageRateResponse(client.CalculatePostageRate(PostageRateClass.ConstructPostageRateRequest(request)));
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::GetPostageRate Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::GetPostageRate Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return postageRateResponse;
		}

		public static IPostageRatesResponse GetPostageRates(IPostageRatesRequest request, ILogger logger = null)
		{
			string message;
			IPostageRatesResponse postageRatesResponse;
			try
			{
				EwsLabelService client = new EwsLabelService();
				postageRatesResponse = PostageRatesClass.ConstructPostageRatesResponse(client.CalculatePostageRates(PostageRatesClass.ConstructPostageRatesRequest(request)));
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::GetPostageRates Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::GetPostageRates Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return postageRatesResponse;
		}

		public static ILabelRequestResponse PrintLabel(ILabelRequestRequest request, ILogger logger = null)
		{
			string message;
			ILabelRequestResponse labelRequestResponse;
			KeyValuePair<string, string>[] keyValuePair;
			int orderId;
			try
			{
				EwsLabelService client = new EwsLabelService();
                

                ILabelRequestResponse response = PrintLabelsClass.ConstructLabelResponse(client.GetPostageLabel(PrintLabelsClass.ConstructLabelRequest(request)), request);
				try
				{
					if (response.Status != TransactionResultEnum.Succeed)
					{
						keyValuePair = new KeyValuePair<string, string>[] { new KeyValuePair<string, string>("Type", "LabelRequest"), new KeyValuePair<string, string>("AccountID", request.AccountID), new KeyValuePair<string, string>("ActionStatus", "Failed"), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>) };
						orderId = request.OrderId;
						keyValuePair[3] = new KeyValuePair<string, string>("OrderID", orderId.ToString());
						keyValuePair[4] = new KeyValuePair<string, string>("Host", HttpContext.Current.Request.Url.Host);
						keyValuePair[5] = new KeyValuePair<string, string>("ErrorMessage", response.ErrorMessage);
						keyValuePair[6] = new KeyValuePair<string, string>("IP", HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
						ShippingInfo.Info(keyValuePair);
					}
					else
					{
						keyValuePair = new KeyValuePair<string, string>[] { new KeyValuePair<string, string>("Type", "LabelRequest"), new KeyValuePair<string, string>("AccountID", request.AccountID), new KeyValuePair<string, string>("ActionStatus", "Succeed"), new KeyValuePair<string, string>("TrackingNumber", response.TrackingNumber), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>), default(KeyValuePair<string, string>) };
						orderId = response.TransactionId;
						keyValuePair[4] = new KeyValuePair<string, string>("TransactionID", orderId.ToString());
						orderId = request.OrderId;
						keyValuePair[5] = new KeyValuePair<string, string>("OrderID", orderId.ToString());
						keyValuePair[6] = new KeyValuePair<string, string>("Host", HttpContext.Current.Request.Url.Host);
						keyValuePair[7] = new KeyValuePair<string, string>("ErrorMessage", response.ErrorMessage);
						keyValuePair[8] = new KeyValuePair<string, string>("IP", HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]);
						ShippingInfo.Info(keyValuePair);
					}
				}
				catch
				{
				}
				labelRequestResponse = response;
			}
			catch (BadRequestException badRequestException)
			{
				message = string.Format("Endicia::Invoker::PrintLabel Failed({0}).", badRequestException.Message);
				Logger.ExternalLogDebug(logger, message);
				throw;
			}
			catch (Exception exception)
			{
				Exception ex = exception;
				message = string.Format("Endicia::Invoker::PrintLabel Failed({0}).", ex.Message);
				Logger.ExternalLogDebug(logger, message);
				throw new Exception(message, ex);
			}
			return labelRequestResponse;
		}
	}
}