using Payments.Application.Services;
using Payments.Domain.ApplicationService;
using Polly.Extensions.Http;
using Polly;
using Payments.Domain.InfrustructureService;
using Payments.Infrastructure.banksProvider;
using Payments.Domain.Common;

namespace Payments.PaymentApi
{
    public static class DependencyInjection
    {
        internal static IServiceCollection AddApplication(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPeymentService, PeymentService>();

            builder.Configuration.GetSection("UrlOption").Get<UrlOption>();

            return builder.Services;
        }

        internal static void RegisterHTTPClient<T>(
            this WebApplicationBuilder builder,
            Action<IServiceProvider, HttpClient> configureClient) 
            where T : class
        {
            builder.Services.AddHttpClient<T>(configureClient)
                .AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());
            


            IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
            {
                return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(5, TimeSpan.FromSeconds(30));
            }
            IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
            {
                return HttpPolicyExtensions
                    .HandleTransientHttpError()
                    .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                    .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
            }
        }
    }
}
