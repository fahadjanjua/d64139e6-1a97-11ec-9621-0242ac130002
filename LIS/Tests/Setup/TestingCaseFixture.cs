using System;
using System.Net.Http;

namespace Tests.Setup
{
    public class LISCaseFixture<TStartup> : IDisposable where TStartup : class
    {
        private readonly LISWebApplicationFactory<TStartup> _factory;
        protected readonly HttpClient Client;
        
        public LISCaseFixture()
        {
            // constructs the testing server with the HostBuilder configuration
            _factory = new LISWebApplicationFactory<TStartup>();

            // Create an HttpClient to send requests to the TestServer
            Client = _factory.CreateClient();
        }

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}
