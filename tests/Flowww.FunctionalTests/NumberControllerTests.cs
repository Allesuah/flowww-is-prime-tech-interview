using System.Net;
using System.Net.Http.Json;
using static Flowww.WebApi.Features.Number.GetEndpoint;

namespace Flowww.FunctionalTests
{
    public class NumberControllerTests
    {
        HttpClient _httpClient;
        public NumberControllerTests()
        {
            var api = new FlowwwWebApiFactory();
            _httpClient = api.CreateClient();
        }

        [Fact]
        public async void Should_ReturnTrue_When_ClientSendsPrimeNumber()
        {
            //Arrange/Act
            var response = await _httpClient.GetAsync(GetEndpoint(5));
            var body = await response.Content.ReadFromJsonAsync<GetPrimeNumberResponseDTO>();

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.True(body.IsPrime);
        }

        [Fact]
        public async void Should_ReturnFalse_When_ClientSendsCompositeNumber()
        {
            //Arrange/Act
            var response = await _httpClient.GetAsync(GetEndpoint(4));
            var body = await response.Content.ReadFromJsonAsync<GetPrimeNumberResponseDTO>();

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.False(body.IsPrime);
        }

        private static string GetEndpoint(int numberParameter)
        {
            return $"api/numbers/{numberParameter}/prime";
        }
    }
}