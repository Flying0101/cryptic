using CryptoWeb.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Text;

namespace CryptoXTest
{
    public class ApiTests : IClassFixture<WebApplicationFactory<CryptoWeb.Program>>
    {
        private readonly HttpClient _client;
        private readonly WebApplicationFactory<CryptoWeb.Program> _factory;

        public ApiTests(WebApplicationFactory<CryptoWeb.Program> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task App_IsReachable()
        {
            var response = await _client.GetAsync("/");

            response.EnsureSuccessStatusCode();  
        }

        [Fact]
        public async Task RootRoute_ReturnsSuccess()
        {
            var response = await _client.GetAsync("/");

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}

