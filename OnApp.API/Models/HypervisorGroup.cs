using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class HypervisorGroup
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

        [JsonProperty("prefer_local_reads")]
        public bool PreferLocalReads { get; set; }

        [JsonProperty("storage_channel")]
        public int StorageChannel { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("vlan")]
        public object Vlan { get; set; }


        public List<HypervisorGroup> GetAll()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/hypervisor_zones.json"
                };

            var model = Client.Instance.RestExecute<List<HypervisorGroupContainer>>(request);
            return model.Select(vm => vm.HypervisorGroup).ToList();
        }


        public HypervisorGroup Get(int id)
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/hypervisor_zones/" + id + ".json"
                };

            var model = Client.Instance.RestExecute<HypervisorGroupContainer>(request);
            return model.HypervisorGroup;
        }

        public List<Hypervisor> GetHypervisorsInZone()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/hypervisor_zones/" + Id + "/hypervisors.json"
                };

            var model = Client.Instance.RestExecute<List<HypervisorContainer>>(request);
            return model.Select(vm => vm.Hypervisor).ToList();
        }
    }

    public class HypervisorGroupContainer
    {
        [JsonProperty("hypervisor_group")]
        public HypervisorGroup HypervisorGroup { get; set; }
    }
}