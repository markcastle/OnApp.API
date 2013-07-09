using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnApp.API.Models
{

    public class VirtualServerIp
    {

        [JsonProperty("ip_address")]
        public IpAddress Value { get; set; }


    }

}
