using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class DataStoreGroup
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_burst_iops")]
        public int DefaultBurstIops { get; set; }

        [JsonProperty("default_gateway")]
        public object DefaultGateway { get; set; }

        [JsonProperty("default_max_iops")]
        public int DefaultMaxIops { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("memory_guarantee")]
        public bool MemoryGuarantee { get; set; }

        [JsonProperty("min_disk_size")]
        public int MinDiskSize { get; set; }

        [JsonProperty("network_failure")]
        public bool NetworkFailure { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("vlan")]
        public object Vlan { get; set; }


        public List<DataStoreGroup> GetAll()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/data_store_zones.json"
                };

            var model = Client.Instance.RestExecute<List<DataStoreGroupContainer>>(request);
            return model.Select(vm => vm.DataStoreGroup).ToList();
        }


        public DataStoreGroup Get(int id)
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/data_store_zones/" + id + ".json"
                };

            var model = Client.Instance.RestExecute<DataStoreGroupContainer>(request);
            return model.DataStoreGroup;
        }
    }


    public class DataStoreGroupContainer
    {
        [JsonProperty("data_store_group")]
        public DataStoreGroup DataStoreGroup { get; set; }
    }
}