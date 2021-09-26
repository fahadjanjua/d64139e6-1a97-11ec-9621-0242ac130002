using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using API;
using FluentAssertions;
using Tests.Setup;
using Xunit;

namespace Tests
{
    public class IntegrationTests : LISCaseFixture<Startup>
    {
        [Fact]
        public async Task PostRquestToAPI_RunsTestCase1_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[0]);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                var result = response.Content.ReadAsStringAsync();
                Assert.Equal(result.Result, TestCases.testCaseResults[0]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase2_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[1]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[1]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase3_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[2]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[2]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase4_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[3]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[3]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase5_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[4]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[4]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase6_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[5]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[5]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase7_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[6]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[6]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase8_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[7]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[7]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase9_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[8]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[8]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase10_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[9]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[9]);
        }

        [Fact]
        public async Task PostRquestToAPI_RunsTestCase11_ReturnsOKAndResultIsALIS()
        {
            var response = await Client.PostAsJsonAsync("api/LIS", TestCases.testCases[10]);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = response.Content.ReadAsStringAsync();
            Assert.Equal(result.Result, TestCases.testCaseResults[10]);
        }
    }
}
