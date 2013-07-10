using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace OnApp.API.Models
{

    public class Network
    {

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_nat_rule_number")]
        public int DefaultNatRuleNumber { get; set; }

        [JsonProperty("default_outside_ip_address_id")]
        public object DefaultOutsideIpAddressId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("ip_address_pool_id")]
        public object IpAddressPoolId { get; set; }

        [JsonProperty("is_nated")]
        public object IsNated { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("network_group_id")]
        public int NetworkGroupId { get; set; }

        [JsonProperty("prefix_size")]
        public object PrefixSize { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public object UserId { get; set; }

        [JsonProperty("vlan")]
        public int Vlan { get; set; }

        public List<Network> GetAll()
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/settings/networks.json"
            };

            var model = Client.Instance.RestExecute<List<NetworkContainer>>(request);
            return model.Select(vm => vm.Network).ToList();
        }


        public Network Get(int id)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json,
                Resource = "/settings/networks/" + id + ".json"
            };

            var model = Client.Instance.RestExecute<NetworkContainer>(request);
            return model.Network;
        }

    }


    public class NetworkContainer
    {
        [JsonProperty("network")]
        public Network Network { get; set; }
    }
}
