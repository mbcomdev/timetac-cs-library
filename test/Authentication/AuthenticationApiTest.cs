using NUnit.Framework;
using System.Threading.Tasks;
using TimeTac_Libary;
using TimeTac_Libary.Authentication;

namespace TimeTac_LibaryTest.Authentication
{
    public class AuthenticationApiTest
    {
        private AuthenticationApi authenticationApi;
        [SetUp]
        public void Setup()
        {
            ApiConfigModel config = new ApiConfigModel
            {
                Host = "go-sandbox.timetac.com",
                Version = 3,
                Account = "mbcomitsystemhaus"
            };
            authenticationApi = new AuthenticationApi(config);
        }

        [Test]
        public async Task TestLogin()
        {
            PasswordCredentialModel credentials = new PasswordCredentialModel
            {
                Client_id = "TT_CUSTOMER_APP_1",
                Client_secret = "DPPSADva8gwRTUZBfHQE",
                Username = "manager",
                Password = "63c3a8"
            };
            TokenModel token = await authenticationApi.Login(credentials);
            TokenModel getToken = authenticationApi.GetTokens();
            Assert.IsNotNull(token.Access_token);
            Assert.IsNotNull(token.Refresh_token);
            Assert.IsNotNull(getToken.Access_token);
            Assert.IsNotNull(getToken.Refresh_token);
            Assert.AreEqual(getToken, getToken);
        }
    }
}