using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API
{
    public class Client
    {
        private static readonly object Mutex = new object();
        private static volatile Client _instance;

        private Client()
        {
        }


        public static Client Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new Client();
                        }
                    }
                }
                return _instance;
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }


        public T RestExecute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient {BaseUrl = Host, Authenticator = new HttpBasicAuthenticator(Username, Password)};

            IRestResponse response = client.Execute(request);

            string json = response.Content;


            return JsonConvert.DeserializeObject<T>(json);
        }

        public string ExecuteResponse<T>(RestRequest request) where T : new()
        {
            var client = new RestClient {BaseUrl = Host, Authenticator = new HttpBasicAuthenticator(Username, Password)};

            IRestResponse response = client.Execute(request);

            return response.Content;
        }


        public void Execute(RestRequest request)
        {
            var client = new RestClient {BaseUrl = Host, Authenticator = new HttpBasicAuthenticator(Username, Password)};

            IRestResponse response = client.Execute(request);

            string json = response.Content;
        }
    }
}