
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnApp.API.Models
{

    public class Models
    {

        [JsonProperty("virtual_machine")]
        public VirtualMachine VirtualMachine { get; set; }

    }

}
