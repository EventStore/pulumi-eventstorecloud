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
    /// The provider type for the eventstorecloud package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [EventStoreCloudResourceType("pulumi:providers:eventstorecloud")]
    public partial class Provider : Pulumi.ProviderResource
    {
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        [Output("identityProviderUrl")]
        public Output<string> IdentityProviderUrl { get; private set; } = null!;

        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        [Output("token")]
        public Output<string> Token { get; private set; } = null!;

        [Output("tokenStore")]
        public Output<string> TokenStore { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs args, CustomResourceOptions? options = null)
            : base("eventstorecloud", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/EventStore/pulumi-eventstorecloud/releases/download/0.2.7-alpha.1670580025+3f729087.dirty",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : Pulumi.ResourceArgs
    {
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        [Input("identityProviderUrl", required: true)]
        public Input<string> IdentityProviderUrl { get; set; } = null!;

        [Input("organizationId", required: true)]
        public Input<string> OrganizationId { get; set; } = null!;

        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        [Input("tokenStore", required: true)]
        public Input<string> TokenStore { get; set; } = null!;

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public ProviderArgs()
        {
        }
    }
}
