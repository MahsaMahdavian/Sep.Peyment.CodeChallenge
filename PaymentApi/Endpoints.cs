using Microsoft.AspNetCore.Mvc;
using PaymentApi.Models;
using Payments.Application.Dto;
using Payments.Domain.ApplicationService;
using Payments.Domain.Enum;
using Payments.Domain.ViewModel;

namespace PaymentApi
{
    abstract class Endpoints
    {
        public static Task<ApiResultModel<BankingOutputViewModel>> SendToPayment([FromBody] TransactionInfoViewModel model,[FromServices] IPeymentService service)
        {
            //I should get BankType From MyCard that there isn't in model that user should choose I think it comes from Authenticate from Cookie or anything else
            BankingInputViewModel bankingInputViewModel = new() 
            {
                Amount = model.Amount,
                CardNo="6219861063383978",//it comes drom Cookie
                CellPhoneNumber="09355854104",
                Cvv2=model.Cvv2,
                ExpireDate=model.ExpireDate,
                RecipientCardNo=model.RecipientCardNo,
                Pin2=model.Pin2
            };
           return service.TransactionByCard(BankType.saman, bankingInputViewModel).ToResult();
        }
    }
}
