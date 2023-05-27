namespace Payments.PaymentApi.Models
{
    record ApiResultModel
    {
        public ApiResultModel(string message)
        {
            Message = message;
        }

        public ApiResultModel()
        {
            Success = true;
        }
        public bool Success { get; protected set; }
        public string? Message { get; }
    }

    record ApiResultModel<T> : ApiResultModel
    {
        public ApiResultModel(T result) : base()
        {
            Success = true;
            Result = result;
        }
        public T Result { get; }
    }
}
