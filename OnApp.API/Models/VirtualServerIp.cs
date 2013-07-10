using Newtonsoft.Json;

namespace OnApp.API.Models
{
    public class VirtualServerIp
    {
        [JsonProperty("ip_address")]
        public IpAddress Value { get; set; }
    }
}