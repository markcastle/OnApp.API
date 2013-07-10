using Newtonsoft.Json;

namespace OnApp.API.Models
{
    public class Params
    {
        [JsonProperty("remote_ip")]
        public string RemoteIp { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("destroy_msg")]
        public string DestroyMsg { get; set; }

        [JsonProperty("shutdown_type")]
        public string ShutdownType { get; set; }

        [JsonProperty("licensing_type")]
        public string LicensingType { get; set; }

        [JsonProperty("licensing_info")]
        public object LicensingInfo { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("encryption_key")]
        public object EncryptionKey { get; set; }

        [JsonProperty("new_operating_system")]
        public string NewOperatingSystem { get; set; }

        [JsonProperty("required_format")]
        public bool? RequiredFormat { get; set; }

        [JsonProperty("type_of_format")]
        public string TypeOfFormat { get; set; }

        [JsonProperty("required_startup")]
        public bool? RequiredStartup { get; set; }

        [JsonProperty("new_password")]
        public string NewPassword { get; set; }

        [JsonProperty("new_cpus")]
        public int? NewCpus { get; set; }

        [JsonProperty("new_memory")]
        public int? NewMemory { get; set; }

        [JsonProperty("new_cpu_shares")]
        public int? NewCpuShares { get; set; }
    }
}