using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LIS.API;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace LIS.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public async Task PostRquestToAPI_RunsAllElevenTestCases_ReturnOKAndResultIsALIS()
        {
            var waf = new WebApplicationFactory<Startup>();
            var client = waf.CreateDefaultClient();

            int testIndex = 0;
            foreach (var testCase in Setup.testCases)
            {
                var response = await client.PostAsJsonAsync("api/LIS", testCase);
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                var result = response.Content.ReadAsStringAsync();
                Assert.Equal(result.Result, Setup.testCaseResults[testIndex]);
                testIndex++;
            }
        }

    }
}
