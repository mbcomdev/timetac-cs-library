using System.Collections.Generic;

namespace TimeTac_Library.Authentication
{
    public class PasswordCredentialModel
    {
        public readonly string Grant_type = "password";
        public string Client_id { get; set; }

        public string Client_secret { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public IEnumerable<KeyValuePair<string, string>> GetKeyValuePairs()
        {
            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", Grant_type),
                new KeyValuePair<string, string>("client_id", Client_id),
                new KeyValuePair<string, string>("client_secret", Client_secret),
                new KeyValuePair<string, string>("username", Username),
                new KeyValuePair<string, string>("password", Password)
            };
            return keyValuePairs;
        }
    }
}
