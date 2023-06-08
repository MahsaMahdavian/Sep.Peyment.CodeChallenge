using Microsoft.AspNetCore.Mvc;
using PaymentApi.Extensions;
using Payments.PaymentApi.Models;
using Payments.Application.ViewModels;
using Payments.Domain.ApplicationService;
using Payments.Domain.Dtos;
using Payments.Domain.Entity.Accounts.ValueObject;

namespace Payments.PaymentApi
{
    abstract class Endpoints
    {
        public static Task<ApiResultModel<BankingOutputDto>> SendToPayment([FromBody] TransactionInfoViewModel model,[FromServices] IPeymentService service)
        {
            //I should get BankType From MyCard that there isn't in model that user should choose I think it comes from Authenticate from Cookie or anything else
            BankingInputDto bankingInputViewModel = new() 
            {
                Amount = model.Amount,
                CardNo="6219861063383978",//it comes drom Cookie
                CellPhoneNumber="111111111",
                Cvv2=model.Cvv2,
                ExpireDate=model.ExpireDate,
                RecipientCardNo=model.RecipientCardNo,
                Pin2=model.Pin2,
                
            };
           return service.TransactionByCard(BankType.Create(bankingInputViewModel.CardNo), bankingInputViewModel).ToResult();
        }
    }
}
