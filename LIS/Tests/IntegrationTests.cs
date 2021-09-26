using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using API;
using FluentAssertions;
using Tests.Setup;
using Xunit;

namespace Tests
{
    public class IntegrationTests : IClassFixture<LISWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public IntegrationTests(LISWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateDefaultClient();
        }


        [Fact]
        public async Task PostRquestToAPI_RunsTestCase1_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[0];
            var output = TestCases.testCaseResults[0];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);
            
            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase2_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[1];
            var output = TestCases.testCaseResults[1];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase3_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[2];
            var output = TestCases.testCaseResults[2];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase4_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[3];
            var output = TestCases.testCaseResults[3];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);
            
            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase5_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[4];
            var output = TestCases.testCaseResults[4];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase6_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[5];
            var output = TestCases.testCaseResults[5];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase7_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[6];
            var output = TestCases.testCaseResults[6];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase8_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[7];
            var output = TestCases.testCaseResults[7];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase9_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[8];
            var output = TestCases.testCaseResults[8];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase10_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[9];
            var output = TestCases.testCaseResults[9];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase11_ReturnsOKAndResultIsALIS()
        {
            //Arrange
            var input = TestCases.testCases[10];
            var output = TestCases.testCaseResults[10];

            //Act
            var response = await _client.PostAsJsonAsync("api/LIS", input);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.ReadAsStringAsync().Result.Should().Be(output);
        }
    }
}
