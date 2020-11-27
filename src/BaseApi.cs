using System;
using System.Net.Http;
using System.Threading.Tasks;
using TimeTac_Library.Utils;

namespace TimeTac_Library
{
    public abstract class BaseApi
    {

        private readonly string DEFAULT_HOST = "go.timetac.com";
        private readonly int DEFAULT_API_VERSION = 3;

        public ApiConfigModel config;

        public ResponseHandler responseHandler;

        private readonly HttpClient client;

        public BaseApi(ApiConfigModel config)
        {
            this.config = config;
            client = new HttpClient();
            responseHandler = new ResponseHandler();
        }

        protected string GetAccountUrl()
        {
            return $"https://{config.Host ?? DEFAULT_HOST}/{config.Account}/";
        }

        protected string GetApiPath()
        {
            return $"{GetAccountUrl()}userapi/v{config.Version ?? DEFAULT_API_VERSION}/";
        }
        private void SetOptions()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", config.AccessToken);
        }

        protected Task<HttpResponseMessage> _get(string endpoint)
        {
            SetOptions();
            Console.WriteLine(GetApiPath() + endpoint);
            return client.GetAsync(GetApiPath() + endpoint);
        }
    }
}
