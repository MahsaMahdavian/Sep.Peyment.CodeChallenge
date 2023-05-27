using Payments.PaymentApi.Models;

namespace PaymentApi.Extensions
{
    static class ProgramExtensions
    {
        public static async Task<ApiResultModel<T>> ToResult<T>(this Task<T> task)
        {
            var result = await task;
            return new ApiResultModel<T>(result);
        }

        public static async Task<ApiResultModel> ToResult(this Task task)
        {
            await task;
            return new ApiResultModel();
        }
    }
}
