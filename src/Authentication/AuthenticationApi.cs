using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TimeTac_Libary.Authentication
{
    public class AuthenticationApi : BaseApi
    {
        public AuthenticationApi(ApiConfigModel config) : base(config) { }

        private void SetTokens(TokenModel token)
        {
            config.AccessToken = token.Access_token;
            config.RefreshToken = token.Refresh_token;
        }

        public TokenModel GetTokens()
        {
            return new TokenModel
            {
                Access_token = config.AccessToken,
                Refresh_token = config.RefreshToken
            };
        }
        private Task<HttpResponseMessage> RequestTokens(PasswordCredentialModel credentials)
        {
            HttpClient client = new HttpClient();
            FormUrlEncodedContent data = new FormUrlEncodedContent(credentials.GetKeyValuePairs());
            return client.PostAsync($"{GetAccountUrl()}auth/oauth2/token", data);
        }

        public async Task<TokenModel> Login(PasswordCredentialModel credentials)
        {
            HttpResponseMessage response = await RequestTokens(credentials);
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
            TokenModel token = JsonSerializer.Deserialize<TokenModel>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            SetTokens(token);
            return token;
        }
    }
}
