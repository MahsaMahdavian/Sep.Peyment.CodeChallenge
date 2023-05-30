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
        private readonly HttpClient _client;
        public Ayande(HttpClient client)
        {
            _client = client;
        }
        public async Task<BankingOutputDto> RunAsync(BankingInputDto input, CancellationToken cancellationToken = default)
        {

            string jsonData = JsonConvert.SerializeObject(input);
            HttpContent Content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("route", Content);
            string responseContent = await response.Content.ReadAsStringAsync();
            BankingOutputDto responseModel = JsonConvert.DeserializeObject<BankingOutputDto>(responseContent);

            return responseModel;
        }
    }
}
