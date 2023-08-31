// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.EventStoreCloud
{
    public static class GetNetwork
    {
        /// <summary>
        /// Retrieves data for an existing `Network` resource
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using EventStoreCloud = Pulumi.EventStoreCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = EventStoreCloud.GetNetwork.Invoke(new()
        ///     {
        ///         Name = "Example Network",
        ///         ProjectId = @var.Project_id,
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkCidr"] = example.Apply(getNetworkResult =&gt; getNetworkResult.CidrBlock),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetNetworkResult> InvokeAsync(GetNetworkArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNetworkResult>("eventstorecloud:index/getNetwork:getNetwork", args ?? new GetNetworkArgs(), options.WithDefaults());

        /// <summary>
        /// Retrieves data for an existing `Network` resource
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using EventStoreCloud = Pulumi.EventStoreCloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = EventStoreCloud.GetNetwork.Invoke(new()
        ///     {
        ///         Name = "Example Network",
        ///         ProjectId = @var.Project_id,
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkCidr"] = example.Apply(getNetworkResult =&gt; getNetworkResult.CidrBlock),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetNetworkResult> Invoke(GetNetworkInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNetworkResult>("eventstorecloud:index/getNetwork:getNetwork", args ?? new GetNetworkInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNetworkArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("projectId", required: true)]
        public string ProjectId { get; set; } = null!;

        public GetNetworkArgs()
        {
        }
        public static new GetNetworkArgs Empty => new GetNetworkArgs();
    }

    public sealed class GetNetworkInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        public GetNetworkInvokeArgs()
        {
        }
        public static new GetNetworkInvokeArgs Empty => new GetNetworkInvokeArgs();
    }


    [OutputType]
    public sealed class GetNetworkResult
    {
        /// <summary>
        /// Address space of the network in CIDR block notation
        /// </summary>
        public readonly string CidrBlock;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string ProjectId;
        /// <summary>
        /// Provider region in which to provision the network
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Cloud Provider in which to provision the network.
        /// </summary>
        public readonly string ResourceProvider;

        [OutputConstructor]
        private GetNetworkResult(
            string cidrBlock,

            string id,

            string name,

            string projectId,

            string region,

            string resourceProvider)
        {
            CidrBlock = cidrBlock;
            Id = id;
            Name = name;
            ProjectId = projectId;
            Region = region;
            ResourceProvider = resourceProvider;
        }
    }
}
