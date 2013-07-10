using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;


namespace OnApp.API.Models
{

    public class Transaction
    {

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("actor")]
        public object Actor { get; set; }

        [JsonProperty("allowed_cancel")]
        public bool AllowedCancel { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dependent_transaction_id")]
        public int? DependentTransactionId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("log_output")]
        public string LogOutput { get; set; }

        [JsonProperty("params")]
        public Params Params { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("parent_type")]
        public string ParentType { get; set; }

        [JsonProperty("pid")]
        public int? Pid { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("start_after")]
        public string StartAfter { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        public List<Transaction> GetAll()
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/transactions.json"
            };

            var model = Client.Instance.RestExecute<List<TransactionContainer>>(request);
            return model.Select(vm => vm.Transaction).ToList();
        }


        public Transaction Get(int id)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/transactions/" + id + ".json"
            };

            var model = Client.Instance.RestExecute<TransactionContainer>(request);
            return model.Transaction;
        }
    
    }


    public class TransactionContainer
    {
        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }
    }

}
