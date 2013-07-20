OnApp.API - WIP
-------------------------

A .NET Library for the OnApp REST API

A wish could be that OnApp would remove the multidimensional array's in their json results.This would be a lot easier for de- and serializing

Usage
---
Define Client.Instance and you should be ready to rock
	
	Client.Instance.Host = "http://controlpanel/";
	Client.Instance.Username = "admin";
	Client.Instance.Password = "changeme";

	// Create Virtual machine
	var nm = new VirtualMachine();
	nm.Memory = 512;
	nm.Cpus = 1;
	nm.CpuShares = 10;
	nm.Hostname = "machinefrom api";
	nm.Label = nm.Hostname;
	nm.PrimaryDiskSize = "5";
	nm.SwapDiskSize = "1";
	nm.RequiredVirtualMachineBuild = "1";
	nm.RequiredIpAddressAssignment = "1";
	nm.HypervisorId = 2;
	nm.TemplateId = 2;
	var machine = nm.Create();

	Console.WriteLine("Id: " + machine.Id);
	Console.WriteLine("Name: " + machine.Label);
	Console.WriteLine("Memory: " + machine.Memory);
	Console.WriteLine("CPU: " + machine.Cpus);
	Console.WriteLine("Password: " + machine.InitialRootPassword);
	
	foreach (var ip in machine.IpAddresses)
	{
		Console.WriteLine("IP: " + ip.IpAddress.Address);   
	}


Supported Methods
-------------------------
* Virtual Machines
* Hypervisor
* Hypervisor Groups
* Image Template
* Logs
* Transactions
* Network

Visit my blog for more <a href="http://morten.io/onapp-api-net-wrapper/">samples</a>
