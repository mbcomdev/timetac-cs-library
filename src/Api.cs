using TimeTac_Libary.Authentication;
using TimeTac_Libary.Tasks;

namespace TimeTac_Libary
{
    public class Api
    {
        public ApiConfigModel Config { get; set; }
        public AuthenticationApi Authentication { get; set; }
        public TaskApi Task { get; set; }

        public Api (ApiConfigModel config)
        {
            Config = config;
            Authentication = new AuthenticationApi(config);
            Task = new TaskApi(config);
        }

    }
}
