using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class LogItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("target_id")]
        public int TargetId { get; set; }

        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        public List<LogItem> GetAll()
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/logs.json"
            };

            var model = Client.Instance.RestExecute<List<LogitemContainer>>(request);
            return model.Select(vm => vm.LogItem).ToList();
        }


        public LogItem Get(int id)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/logs/" + id + ".json"
            };

            var model = Client.Instance.RestExecute<LogitemContainer>(request);
            return model.LogItem;
        }
    }

    public class LogitemContainer
    {
        [JsonProperty("log_item")]
        public LogItem LogItem { get; set; }
    }
}