using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace OnApp.API.Models
{
    public class VirtualMachine
    {
        [JsonProperty("add_to_marketplace")]
        public object AddToMarketplace { get; set; }

        [JsonProperty("admin_note")]
        public object AdminNote { get; set; }

        [JsonProperty("allow_resize_without_reboot")]
        public bool AllowResizeWithoutReboot { get; set; }

        [JsonProperty("allowed_hot_migrate")]
        public bool AllowedHotMigrate { get; set; }

        [JsonProperty("allowed_swap")]
        public bool AllowedSwap { get; set; }

        [JsonProperty("booted")]
        public bool Booted { get; set; }

        [JsonProperty("built")]
        public bool Built { get; set; }

        [JsonProperty("cpu_shares")]
        public int CpuShares { get; set; }

        [JsonProperty("cpus")]
        public int Cpus { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("customer_network_id")]
        public object CustomerNetworkId { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("edge_server_type")]
        public object EdgeServerType { get; set; }

        [JsonProperty("enable_autoscale")]
        public string EnableAutoscale { get; set; }

        [JsonProperty("enable_monitis")]
        public string EnableMonitis { get; set; }

        [JsonProperty("firewall_notrack")]
        public bool FirewallNotrack { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("hypervisor_id")]
        public int HypervisorId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("initial_root_password")]
        public string InitialRootPassword { get; set; }

        [JsonProperty("initial_root_password_encrypted")]
        public bool InitialRootPasswordEncrypted { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("local_remote_access_ip_address")]
        public string LocalRemoteAccessIpAddress { get; set; }

        [JsonProperty("local_remote_access_port")]
        public object LocalRemoteAccessPort { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("memory")]
        public int Memory { get; set; }

        [JsonProperty("min_disk_size")]
        public int MinDiskSize { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("operating_system")]
        public string OperatingSystem { get; set; }

        [JsonProperty("operating_system_distro")]
        public string OperatingSystemDistro { get; set; }

        [JsonProperty("preferred_hvs")]
        public int[] PreferredHvs { get; set; }

        [JsonProperty("recovery_mode")]
        public bool? RecoveryMode { get; set; }

        [JsonProperty("remote_access_password")]
        public string RemoteAccessPassword { get; set; }

        [JsonProperty("service_password")]
        public object ServicePassword { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("storage_server_type")]
        public object StorageServerType { get; set; }

        [JsonProperty("strict_virtual_machine_id")]
        public object StrictVirtualMachineId { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        [JsonProperty("template_label")]
        public string TemplateLabel { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("vip")]
        public object Vip { get; set; }

        [JsonProperty("xen_id")]
        public object XenId { get; set; }

        [JsonProperty("ip_addresses")]
        public IpAddressContainer[] IpAddresses { get; set; }

        [JsonProperty("monthly_bandwidth_used")]
        public string MonthlyBandwidthUsed { get; set; }

        [JsonProperty("total_disk_size")]
        public int TotalDiskSize { get; set; }

        [JsonProperty("initial_root_password_encryption_key")]
        public string InitialRootPasswordEncryptionKey { get; set; }

        [JsonProperty("licensing_server_id")]
        public string LicensingServerId { get; set; }

        [JsonProperty("licensing_type")]
        public string LicensingType { get; set; }

        [JsonProperty("licensing_key")]
        public string LicensingKey { get; set; }

        [JsonProperty("primary_disk_size")]
        public string PrimaryDiskSize { get; set; }

        [JsonProperty("type_of_format")]
        public string TypeOfFormat { get; set; }

        [JsonProperty("primary_disk_min_iops")]
        public string PrimaryDiskMinIops { get; set; }

        [JsonProperty("swap_disk_min_iops")]
        public string SwapDiskMinIops { get; set; }

        [JsonProperty("data_store_group_primary_id")]
        public string DataStoreGroupPrimaryId { get; set; }

        [JsonProperty("swap_disk_size")]
        public string SwapDiskSize { get; set; }

        [JsonProperty("data_store_group_swap_id")]
        public string DataStoreGroupSwapId { get; set; }

        [JsonProperty("primary_network_id")]
        public string PrimaryNetworkId { get; set; }

        [JsonProperty("primary_network_group_id")]
        public string PrimaryNetworkGroupId { get; set; }

        [JsonProperty("selected_ip_address_id")]
        public string SelectedIpAddressId { get; set; }

        [JsonProperty("required_automatic_backup")]
        public string RequiredAutomaticBackup { get; set; }

        [JsonProperty("rate_limit")]
        public string RateLimit { get; set; }

        [JsonProperty("required_ip_address_assignment")]
        [DefaultValue("1")]
        public string RequiredIpAddressAssignment { get; set; }

        [JsonProperty("required_virtual_machine_build")]
        [DefaultValue("1")]
        public string RequiredVirtualMachineBuild { get; set; }

        [JsonProperty("required_virtual_machine_startup")]
        [DefaultValue("1")]
        public string RequiredVirtualMachineStartup { get; set; }

        [JsonProperty("hypervisor_group_id")]
        public string HypervisorGroupId { get; set; }

        public List<VirtualMachine> GetAll()
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "virtual_machines.json"
                };

            var model = Client.Instance.RestExecute<List<VirtualMachineContainer>>(request);
            return model.Select(vm => vm.VirtualMachine).ToList();
        }


        public VirtualMachine Get(int id)
        {
            var request = new RestRequest
                {
                    Method = Method.GET,
                    RequestFormat = DataFormat.Json,
                    Resource = "/virtual_machines/" + id + ".json"
                };

            var model = Client.Instance.RestExecute<VirtualMachineContainer>(request);
            return model.VirtualMachine;
        }


        public void StartUp()
        {
            if (!this.Booted)
            {
                var request = new RestRequest
                    {
                        Method = Method.POST,
                        RequestFormat = DataFormat.Json,
                        Resource = "/virtual_machines/" + Id + "/startup.json"
                    };

                Client.Instance.Execute(request); 
            }
        }



        public void Shutdown()
        {
            if (this.Booted)
            {
                var request = new RestRequest
                    {
                        Method = Method.POST,
                        RequestFormat = DataFormat.Json,
                        Resource = "/virtual_machines/" + Id + "/shutdown.json"
                    };


                Client.Instance.Execute(request);
            }
        }

        public void Reboot()
        {
            if(this.Booted)
            {
                var request = new RestRequest
                    {
                        Method = Method.POST,
                        RequestFormat = DataFormat.Json,
                        Resource = "/virtual_machines/" + Id + "/reboot.json"
                    };


                Client.Instance.Execute(request);
            }
        }


        public void Delete()
        {
            
            var request = new RestRequest
                {
                    Method = Method.DELETE,
                    RequestFormat = DataFormat.Json,
                    Resource = "/virtual_machines/" + Id
                };

            request.AddParameter("convert_last_backup", "1");
            request.AddParameter("destroy_all_backups", "1");


            Client.Instance.Execute(request);
        }


        public VirtualMachine Create()
        {
            var request = new RestRequest
                {
                    Method = Method.POST,
                    RequestFormat = DataFormat.Json,
                    Resource = "virtual_machines.json",
                };


            var model = new VirtualMachineContainer {VirtualMachine = this};

            var json = JsonConvert.SerializeObject(model, new JsonSerializerSettings{NullValueHandling = NullValueHandling.Ignore});
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            var machine = Client.Instance.RestExecute<VirtualMachineContainer>(request);

            return machine.VirtualMachine;
        }
    }

    public class VirtualMachineContainer
    {
        [JsonProperty("virtual_machine")]
        public VirtualMachine VirtualMachine { get; set; }
    }
}