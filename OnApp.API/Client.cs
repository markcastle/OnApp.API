using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace OnApp.API
{
    public class Client
    {

        private static readonly object _mutex = new object();
        private static volatile Client _instance = null;
        private Client() { }



        public static Client Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_mutex)
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

            var response = client.Execute(request);

            var json = response.Content;
          

            return (T)JsonConvert.DeserializeObject<T>(json);
        }


        public void Execute(RestRequest request)
        {
            var client = new RestClient { BaseUrl = Host, Authenticator = new HttpBasicAuthenticator(Username, Password) };

            var response = client.Execute(request);

            var json = response.Content;
        }

        public string ExecuteResponse<T>(RestRequest request) where T : new()
        {
            var client = new RestClient { BaseUrl = Host, Authenticator = new HttpBasicAuthenticator(Username, Password) };

            var response = client.Execute(request);

           return response.Content;
        }

    }
}
