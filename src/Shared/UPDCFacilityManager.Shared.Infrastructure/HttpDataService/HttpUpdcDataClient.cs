using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Shared.Infrastructure.HttpDataService
{
    public class HttpUpdcDataClient : IHttpUpdcDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public HttpUpdcDataClient(HttpClient httpClient, IConfiguration config) 
        {
            _httpClient = httpClient ?? throw new ArgumentNullException();
            _config = config ?? throw new ArgumentNullException("config");
        }

        public Task Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
