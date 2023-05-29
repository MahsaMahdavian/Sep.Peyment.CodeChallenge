using Payments.Domain.Dtos;
using Microsoft.Extensions.Options;
using Payments.Domain.Common;
using System.Text;
using Newtonsoft.Json;
using Payments.Domain.InfrustructureService;

namespace Payments.Infrastructure.banksProvider
{
    public class Ayande:IPayStrategy
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UrlOption _options;
        public Ayande(IHttpClientFactory httpClientFactory, IOptions<UrlOption> options)
        {

            _httpClientFactory = httpClientFactory;
            _options=options.Value;
        }

        public async Task<BankingOutputDto> RunAsync(BankingInputDto input, CancellationToken cancellationToken = default)
        {
            var url = _options.AyandeUrl;
            var client = _httpClientFactory.CreateClient();
            string jsonData = JsonConvert.SerializeObject(input);
            HttpContent Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, Content);
            string responseContent = await response.Content.ReadAsStringAsync();
            BankingOutputDto responseModel = JsonConvert.DeserializeObject<BankingOutputDto>(responseContent);

            return responseModel;
        }
    }
}
