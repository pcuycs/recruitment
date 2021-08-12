using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using Recruitment.API;

namespace Recuitment.Tests
{
    public class CommandControllerTests
    {
        private WebApplicationFactory<Startup> _factory;
        private HttpClient _httpClient;


        [SetUp]
        public void Setup()
        {
            _factory = new WebApplicationFactory<Startup>();
            _httpClient = _factory.CreateClient();
        }

        [TearDown]
        public void TearDown()
        {
            _httpClient.Dispose();
            _factory.Dispose();
        }

        [Test]
        public async Task Call_API_Success()
        {
            var content = new StringContent("{ \"login\": \"123\",  \"password\": \"123\" }", Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("/api/command​/CalculateHashCommand", content);

            result.EnsureSuccessStatusCode();
            (await result.Content.ReadAsStringAsync()).Should().BeEmpty();
        }

        [Test]
        public async Task Call_API_Error_When_Url_Not_Exist()
        {
            var content = new StringContent("{ \"login\": \"123\",  \"password\": \"123\" }", Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync("/api/command/FailCommand", content);

            result.StatusCode.Should().Be(HttpStatusCode.NotFound);
            (await result.Content.ReadAsStringAsync()).Should().BeEmpty();
        }
    }
}