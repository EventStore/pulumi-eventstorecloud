// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.EventStoreCloud
{
    /// <summary>
    /// Manages EventStoreDB instances and clusters in Event Store Cloud
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using EventStoreCloud = Pulumi.EventStoreCloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleProject = Output.Create(EventStoreCloud.GetProject.InvokeAsync(new EventStoreCloud.GetProjectArgs
    ///         {
    ///             Name = "Example Project",
    ///         }));
    ///         var exampleNetwork = new EventStoreCloud.Network("exampleNetwork", new EventStoreCloud.NetworkArgs
    ///         {
    ///             ProjectId = eventstorecloud_project.Example.Id,
    ///             ResourceProvider = "aws",
    ///             Region = "us-west-2",
    ///             CidrBlock = "172.21.0.0/16",
    ///         });
    ///         var exampleManagedCluster = new EventStoreCloud.ManagedCluster("exampleManagedCluster", new EventStoreCloud.ManagedClusterArgs
    ///         {
    ///             ProjectId = exampleNetwork.ProjectId,
    ///             NetworkId = exampleNetwork.Id,
    ///             Topology = "three-node-multi-zone",
    ///             InstanceType = "F1",
    ///             DiskSize = 24,
    ///             DiskType = "gp3",
    ///             DiskIops = 3000,
    ///             DiskThroughput = 125,
    ///             ServerVersion = "20.6",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// ```sh
    ///  $ pulumi import eventstorecloud:index/managedCluster:ManagedCluster example project_id:cluster_id
    /// ```
    /// </summary>
    [EventStoreCloudResourceType("eventstorecloud:index/managedCluster:ManagedCluster")]
    public partial class ManagedCluster : Pulumi.CustomResource
    {
        /// <summary>
        /// Number of IOPS for storage, required if disk_type is `gp3`
        /// </summary>
        [Output("diskIops")]
        public Output<int?> DiskIops { get; private set; } = null!;

        /// <summary>
        /// Size of the data disks, in gigabytes
        /// </summary>
        [Output("diskSize")]
        public Output<int> DiskSize { get; private set; } = null!;

        /// <summary>
        /// Throughput in MB/s for storage, required if disk_type is `gp3`
        /// </summary>
        [Output("diskThroughput")]
        public Output<int?> DiskThroughput { get; private set; } = null!;

        /// <summary>
        /// Storage class of the data disks (find the list of valid values below)
        /// </summary>
        [Output("diskType")]
        public Output<string> DiskType { get; private set; } = null!;

        /// <summary>
        /// DNS address of the cluster
        /// </summary>
        [Output("dnsName")]
        public Output<string> DnsName { get; private set; } = null!;

        /// <summary>
        /// Instance type of the managed cluster (find the list of valid values below)
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// Name of the managed cluster
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network in which the managed cluster exists
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// ID of the project in which the managed cluster exists
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Determines whether to run no projections, system projections only, or system and user projections (find the list of valid values below) Defaults to `off`.
        /// </summary>
        [Output("projectionLevel")]
        public Output<string?> ProjectionLevel { get; private set; } = null!;

        /// <summary>
        /// Region in which the cluster was created. Determined by the region of the Network
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// Provider in which the cluster was created. Determined by the provider of the Network.
        /// </summary>
        [Output("resourceProvider")]
        public Output<string> ResourceProvider { get; private set; } = null!;

        /// <summary>
        /// Server version to provision (find the list of valid values below)
        /// </summary>
        [Output("serverVersion")]
        public Output<string> ServerVersion { get; private set; } = null!;

        /// <summary>
        /// Topology of the managed cluster (`single-node` or `three-node-multi-zone`)
        /// </summary>
        [Output("topology")]
        public Output<string> Topology { get; private set; } = null!;


        /// <summary>
        /// Create a ManagedCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagedCluster(string name, ManagedClusterArgs args, CustomResourceOptions? options = null)
            : base("eventstorecloud:index/managedCluster:ManagedCluster", name, args ?? new ManagedClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ManagedCluster(string name, Input<string> id, ManagedClusterState? state = null, CustomResourceOptions? options = null)
            : base("eventstorecloud:index/managedCluster:ManagedCluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/EventStore/pulumi-eventstorecloud/releases/download/0.2.8",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ManagedCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagedCluster Get(string name, Input<string> id, ManagedClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagedCluster(name, id, state, options);
        }
    }

    public sealed class ManagedClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of IOPS for storage, required if disk_type is `gp3`
        /// </summary>
        [Input("diskIops")]
        public Input<int>? DiskIops { get; set; }

        /// <summary>
        /// Size of the data disks, in gigabytes
        /// </summary>
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        /// <summary>
        /// Throughput in MB/s for storage, required if disk_type is `gp3`
        /// </summary>
        [Input("diskThroughput")]
        public Input<int>? DiskThroughput { get; set; }

        /// <summary>
        /// Storage class of the data disks (find the list of valid values below)
        /// </summary>
        [Input("diskType", required: true)]
        public Input<string> DiskType { get; set; } = null!;

        /// <summary>
        /// Instance type of the managed cluster (find the list of valid values below)
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        /// <summary>
        /// Name of the managed cluster
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network in which the managed cluster exists
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        /// <summary>
        /// ID of the project in which the managed cluster exists
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// Determines whether to run no projections, system projections only, or system and user projections (find the list of valid values below) Defaults to `off`.
        /// </summary>
        [Input("projectionLevel")]
        public Input<string>? ProjectionLevel { get; set; }

        /// <summary>
        /// Server version to provision (find the list of valid values below)
        /// </summary>
        [Input("serverVersion", required: true)]
        public Input<string> ServerVersion { get; set; } = null!;

        /// <summary>
        /// Topology of the managed cluster (`single-node` or `three-node-multi-zone`)
        /// </summary>
        [Input("topology", required: true)]
        public Input<string> Topology { get; set; } = null!;

        public ManagedClusterArgs()
        {
        }
    }

    public sealed class ManagedClusterState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of IOPS for storage, required if disk_type is `gp3`
        /// </summary>
        [Input("diskIops")]
        public Input<int>? DiskIops { get; set; }

        /// <summary>
        /// Size of the data disks, in gigabytes
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// Throughput in MB/s for storage, required if disk_type is `gp3`
        /// </summary>
        [Input("diskThroughput")]
        public Input<int>? DiskThroughput { get; set; }

        /// <summary>
        /// Storage class of the data disks (find the list of valid values below)
        /// </summary>
        [Input("diskType")]
        public Input<string>? DiskType { get; set; }

        /// <summary>
        /// DNS address of the cluster
        /// </summary>
        [Input("dnsName")]
        public Input<string>? DnsName { get; set; }

        /// <summary>
        /// Instance type of the managed cluster (find the list of valid values below)
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Name of the managed cluster
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network in which the managed cluster exists
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        /// <summary>
        /// ID of the project in which the managed cluster exists
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// Determines whether to run no projections, system projections only, or system and user projections (find the list of valid values below) Defaults to `off`.
        /// </summary>
        [Input("projectionLevel")]
        public Input<string>? ProjectionLevel { get; set; }

        /// <summary>
        /// Region in which the cluster was created. Determined by the region of the Network
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// Provider in which the cluster was created. Determined by the provider of the Network.
        /// </summary>
        [Input("resourceProvider")]
        public Input<string>? ResourceProvider { get; set; }

        /// <summary>
        /// Server version to provision (find the list of valid values below)
        /// </summary>
        [Input("serverVersion")]
        public Input<string>? ServerVersion { get; set; }

        /// <summary>
        /// Topology of the managed cluster (`single-node` or `three-node-multi-zone`)
        /// </summary>
        [Input("topology")]
        public Input<string>? Topology { get; set; }

        public ManagedClusterState()
        {
        }
    }
}
