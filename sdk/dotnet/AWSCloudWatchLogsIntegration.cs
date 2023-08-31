// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.EventStoreCloud
{
    [EventStoreCloudResourceType("eventstorecloud:index/aWSCloudWatchLogsIntegration:AWSCloudWatchLogsIntegration")]
    public partial class AWSCloudWatchLogsIntegration : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The access key ID of IAM credentials which have permissions to create and write to the log group
        /// </summary>
        [Output("accessKeyId")]
        public Output<string?> AccessKeyId { get; private set; } = null!;

        /// <summary>
        /// Clusters to be used with this integration
        /// </summary>
        [Output("clusterIds")]
        public Output<ImmutableArray<string>> ClusterIds { get; private set; } = null!;

        /// <summary>
        /// Human readable description of the integration
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Name of the CloudWatch group
        /// </summary>
        [Output("groupName")]
        public Output<string> GroupName { get; private set; } = null!;

        /// <summary>
        /// ID of the project to which the integration applies
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// AWS region for group
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The secret access key of IAM credentials which will be used to write to the log groups
        /// </summary>
        [Output("secretAccessKey")]
        public Output<string?> SecretAccessKey { get; private set; } = null!;


        /// <summary>
        /// Create a AWSCloudWatchLogsIntegration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AWSCloudWatchLogsIntegration(string name, AWSCloudWatchLogsIntegrationArgs args, CustomResourceOptions? options = null)
            : base("eventstorecloud:index/aWSCloudWatchLogsIntegration:AWSCloudWatchLogsIntegration", name, args ?? new AWSCloudWatchLogsIntegrationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AWSCloudWatchLogsIntegration(string name, Input<string> id, AWSCloudWatchLogsIntegrationState? state = null, CustomResourceOptions? options = null)
            : base("eventstorecloud:index/aWSCloudWatchLogsIntegration:AWSCloudWatchLogsIntegration", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/EventStore",
                AdditionalSecretOutputs =
                {
                    "accessKeyId",
                    "secretAccessKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AWSCloudWatchLogsIntegration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AWSCloudWatchLogsIntegration Get(string name, Input<string> id, AWSCloudWatchLogsIntegrationState? state = null, CustomResourceOptions? options = null)
        {
            return new AWSCloudWatchLogsIntegration(name, id, state, options);
        }
    }

    public sealed class AWSCloudWatchLogsIntegrationArgs : global::Pulumi.ResourceArgs
    {
        [Input("accessKeyId")]
        private Input<string>? _accessKeyId;

        /// <summary>
        /// The access key ID of IAM credentials which have permissions to create and write to the log group
        /// </summary>
        public Input<string>? AccessKeyId
        {
            get => _accessKeyId;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessKeyId = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("clusterIds", required: true)]
        private InputList<string>? _clusterIds;

        /// <summary>
        /// Clusters to be used with this integration
        /// </summary>
        public InputList<string> ClusterIds
        {
            get => _clusterIds ?? (_clusterIds = new InputList<string>());
            set => _clusterIds = value;
        }

        /// <summary>
        /// Human readable description of the integration
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Name of the CloudWatch group
        /// </summary>
        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        /// <summary>
        /// ID of the project to which the integration applies
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// AWS region for group
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("secretAccessKey")]
        private Input<string>? _secretAccessKey;

        /// <summary>
        /// The secret access key of IAM credentials which will be used to write to the log groups
        /// </summary>
        public Input<string>? SecretAccessKey
        {
            get => _secretAccessKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretAccessKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AWSCloudWatchLogsIntegrationArgs()
        {
        }
        public static new AWSCloudWatchLogsIntegrationArgs Empty => new AWSCloudWatchLogsIntegrationArgs();
    }

    public sealed class AWSCloudWatchLogsIntegrationState : global::Pulumi.ResourceArgs
    {
        [Input("accessKeyId")]
        private Input<string>? _accessKeyId;

        /// <summary>
        /// The access key ID of IAM credentials which have permissions to create and write to the log group
        /// </summary>
        public Input<string>? AccessKeyId
        {
            get => _accessKeyId;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessKeyId = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("clusterIds")]
        private InputList<string>? _clusterIds;

        /// <summary>
        /// Clusters to be used with this integration
        /// </summary>
        public InputList<string> ClusterIds
        {
            get => _clusterIds ?? (_clusterIds = new InputList<string>());
            set => _clusterIds = value;
        }

        /// <summary>
        /// Human readable description of the integration
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the CloudWatch group
        /// </summary>
        [Input("groupName")]
        public Input<string>? GroupName { get; set; }

        /// <summary>
        /// ID of the project to which the integration applies
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// AWS region for group
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("secretAccessKey")]
        private Input<string>? _secretAccessKey;

        /// <summary>
        /// The secret access key of IAM credentials which will be used to write to the log groups
        /// </summary>
        public Input<string>? SecretAccessKey
        {
            get => _secretAccessKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _secretAccessKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AWSCloudWatchLogsIntegrationState()
        {
        }
        public static new AWSCloudWatchLogsIntegrationState Empty => new AWSCloudWatchLogsIntegrationState();
    }
}
