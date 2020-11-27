using TimeTac_Library.Authentication;
using TimeTac_Library.Tasks;

namespace TimeTac_Library
{
    public class Api
    {
        public ApiConfigModel Config { get; set; }
        public AuthenticationApi Authentication { get; set; }
        public TaskApi Task { get; set; }

        public Api(ApiConfigModel config)
        {
            Config = config;
            Authentication = new AuthenticationApi(config);
            Task = new TaskApi(config);
        }

    }
}
