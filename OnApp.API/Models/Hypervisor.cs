using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class Hypervisor
    {
        [JsonProperty("backup")]
        public bool Backup { get; set; }

        [JsonProperty("backup_ip_address")]
        public string BackupIpAddress { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("built")]
        public bool Built { get; set; }

        [JsonProperty("called_in_at")]
        public object CalledInAt { get; set; }

        [JsonProperty("connection_options")]
        public object ConnectionOptions { get; set; }

        [JsonProperty("cpu_idle")]
        public int CpuIdle { get; set; }

        [JsonProperty("cpu_mhz")]
        public string CpuMhz { get; set; }

        [JsonProperty("cpus")]
        public int Cpus { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("custom_config")]
        public string CustomConfig { get; set; }

        [JsonProperty("disable_failover")]
        public bool DisableFailover { get; set; }

        [JsonProperty("disk_pcis")]
        public string DiskPcis { get; set; }

        [JsonProperty("distro")]
        public string Distro { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("failure_count")]
        public int FailureCount { get; set; }

        [JsonProperty("format_disks")]
        public bool FormatDisks { get; set; }

        [JsonProperty("free_mem")]
        public int FreeMem { get; set; }

        [JsonProperty("host")]
        public object Host { get; set; }

        [JsonProperty("host_id")]
        public int? HostId { get; set; }

        [JsonProperty("hypervisor_group_id")]
        public int? HypervisorGroupId { get; set; }

        [JsonProperty("hypervisor_type")]
        public string HypervisorType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("list_of_logical_volumes")]
        public string ListOfLogicalVolumes { get; set; }

        [JsonProperty("list_of_volume_groups")]
        public string ListOfVolumeGroups { get; set; }

        [JsonProperty("list_of_zombie_domains")]
        public string ListOfZombieDomains { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("mac")]
        public string Mac { get; set; }

        [JsonProperty("machine")]
        public string Machine { get; set; }

        [JsonProperty("mtu")]
        public int Mtu { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("ovs")]
        public object Ovs { get; set; }

        [JsonProperty("passthrough_disks")]
        public bool PassthroughDisks { get; set; }

        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("spare")]
        public bool Spare { get; set; }

        [JsonProperty("storage_channel")]
        public string StorageChannel { get; set; }

        [JsonProperty("threads_per_core")]
        public int ThreadsPerCore { get; set; }

        [JsonProperty("total_mem")]
        public int TotalMem { get; set; }

        [JsonProperty("total_zombie_mem")]
        public int? TotalZombieMem { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }

        [JsonProperty("vmware_total_cpu_cores")]
        public int VmwareTotalCpuCores { get; set; }

        [JsonProperty("total_cpus")]
        public int TotalCpus { get; set; }

        [JsonProperty("free_memory")]
        public int FreeMemory { get; set; }

        [JsonProperty("used_cpu_resources")]
        public int UsedCpuResources { get; set; }

        [JsonProperty("total_memory")]
        public int TotalMemory { get; set; }

        [JsonProperty("cpu_cores")]
        public int CpuCores { get; set; }

        [JsonProperty("free_disk_space")]
        public dynamic FreeDiskSpace { get; set; }

        [JsonProperty("memory_allocated_by_running_vms")]
        public int MemoryAllocatedByRunningVms { get; set; }

        [JsonProperty("total_memory_allocated_by_vms")]
        public int TotalMemoryAllocatedByVms { get; set; }


        public List<Hypervisor> GetAll()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/hypervisors.json"
                };

            var model = Client.Instance.RestExecute<List<HypervisorContainer>>(request);
            return model.Select(vm => vm.Hypervisor).ToList();
        }


        public Hypervisor Get(int id)
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/settings/hypervisors/" + id + ".json"
                };

            var model = Client.Instance.RestExecute<HypervisorContainer>(request);
            return model.Hypervisor;
        }
    }

    public class HypervisorContainer
    {
        [JsonProperty("hypervisor")]
        public Hypervisor Hypervisor { get; set; }
    }
}