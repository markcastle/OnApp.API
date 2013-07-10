using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class ImageTemplate
    {
        [JsonProperty("allow_resize_without_reboot")]
        public bool AllowResizeWithoutReboot { get; set; }

        [JsonProperty("allowed_hot_migrate")]
        public bool AllowedHotMigrate { get; set; }

        [JsonProperty("allowed_swap")]
        public bool AllowedSwap { get; set; }

        [JsonProperty("backup_server_id")]
        public object BackupServerId { get; set; }

        [JsonProperty("cdn")]
        public bool Cdn { get; set; }

        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("disk_target_device")]
        public string DiskTargetDevice { get; set; }

        [JsonProperty("ext4")]
        public bool Ext4 { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initial_password")]
        public object InitialPassword { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("min_disk_size")]
        public int MinDiskSize { get; set; }

        [JsonProperty("min_memory_size")]
        public int MinMemorySize { get; set; }

        [JsonProperty("operating_system")]
        public string OperatingSystem { get; set; }

        [JsonProperty("operating_system_arch")]
        public string OperatingSystemArch { get; set; }

        [JsonProperty("operating_system_distro")]
        public string OperatingSystemDistro { get; set; }

        [JsonProperty("operating_system_edition")]
        public string OperatingSystemEdition { get; set; }

        [JsonProperty("operating_system_tail")]
        public string OperatingSystemTail { get; set; }

        [JsonProperty("parent_template_id")]
        public object ParentTemplateId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("template_size")]
        public int TemplateSize { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public object UserId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("virtualization")]
        public string Virtualization { get; set; }


        public List<ImageTemplate> GetAll()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/templates/all.json"
                };

            var model = Client.Instance.RestExecute<List<ImageTemplateContainer>>(request);
            return model.Select(vm => vm.ImageTemplate).ToList();
        }


        public ImageTemplate Get(int id)
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/templates/" + id + ".json"
                };

            var model = Client.Instance.RestExecute<ImageTemplateContainer>(request);
            return model.ImageTemplate;
        }
    }

    public class ImageTemplateContainer
    {
        [JsonProperty("image_template")]
        public ImageTemplate ImageTemplate { get; set; }
    }
}