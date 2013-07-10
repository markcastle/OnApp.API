using Newtonsoft.Json;

namespace OnApp.API.Models
{
    public class IpAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("broadcast")]
        public string Broadcast { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("customer_network_id")]
        public object CustomerNetworkId { get; set; }

        [JsonProperty("disallowed_primary")]
        public bool DisallowedPrimary { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("hypervisor_id")]
        public object HypervisorId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ip_address_pool_id")]
        public object IpAddressPoolId { get; set; }

        [JsonProperty("network_address")]
        public string NetworkAddress { get; set; }

        [JsonProperty("network_id")]
        public int NetworkId { get; set; }

        [JsonProperty("pxe")]
        public bool Pxe { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public object UserId { get; set; }

        [JsonProperty("free")]
        public bool Free { get; set; }

        [JsonProperty("netmask")]
        public string Netmask { get; set; }
    }


    public class IpAddressContainer
    {
        [JsonProperty("ip_address")]
        public IpAddress IpAddress { get; set; }
    }

}