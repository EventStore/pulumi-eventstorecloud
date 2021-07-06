# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['NetworkArgs', 'Network']

@pulumi.input_type
class NetworkArgs:
    def __init__(__self__, *,
                 cidr_block: pulumi.Input[str],
                 project_id: pulumi.Input[str],
                 region: pulumi.Input[str],
                 resource_provider: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Network resource.
        :param pulumi.Input[str] cidr_block: Address space of the network in CIDR block notation
        :param pulumi.Input[str] project_id: Project ID
        :param pulumi.Input[str] region: Provider region in which to provision the network
        :param pulumi.Input[str] resource_provider: Cloud Provider in which to provision the network.
        :param pulumi.Input[str] name: Human-friendly name for the network
        """
        pulumi.set(__self__, "cidr_block", cidr_block)
        pulumi.set(__self__, "project_id", project_id)
        pulumi.set(__self__, "region", region)
        pulumi.set(__self__, "resource_provider", resource_provider)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Input[str]:
        """
        Address space of the network in CIDR block notation
        """
        return pulumi.get(self, "cidr_block")

    @cidr_block.setter
    def cidr_block(self, value: pulumi.Input[str]):
        pulumi.set(self, "cidr_block", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Input[str]:
        """
        Project ID
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter
    def region(self) -> pulumi.Input[str]:
        """
        Provider region in which to provision the network
        """
        return pulumi.get(self, "region")

    @region.setter
    def region(self, value: pulumi.Input[str]):
        pulumi.set(self, "region", value)

    @property
    @pulumi.getter(name="resourceProvider")
    def resource_provider(self) -> pulumi.Input[str]:
        """
        Cloud Provider in which to provision the network.
        """
        return pulumi.get(self, "resource_provider")

    @resource_provider.setter
    def resource_provider(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_provider", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Human-friendly name for the network
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _NetworkState:
    def __init__(__self__, *,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 resource_provider: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Network resources.
        :param pulumi.Input[str] cidr_block: Address space of the network in CIDR block notation
        :param pulumi.Input[str] name: Human-friendly name for the network
        :param pulumi.Input[str] project_id: Project ID
        :param pulumi.Input[str] region: Provider region in which to provision the network
        :param pulumi.Input[str] resource_provider: Cloud Provider in which to provision the network.
        """
        if cidr_block is not None:
            pulumi.set(__self__, "cidr_block", cidr_block)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project_id is not None:
            pulumi.set(__self__, "project_id", project_id)
        if region is not None:
            pulumi.set(__self__, "region", region)
        if resource_provider is not None:
            pulumi.set(__self__, "resource_provider", resource_provider)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> Optional[pulumi.Input[str]]:
        """
        Address space of the network in CIDR block notation
        """
        return pulumi.get(self, "cidr_block")

    @cidr_block.setter
    def cidr_block(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cidr_block", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Human-friendly name for the network
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> Optional[pulumi.Input[str]]:
        """
        Project ID
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter
    def region(self) -> Optional[pulumi.Input[str]]:
        """
        Provider region in which to provision the network
        """
        return pulumi.get(self, "region")

    @region.setter
    def region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region", value)

    @property
    @pulumi.getter(name="resourceProvider")
    def resource_provider(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud Provider in which to provision the network.
        """
        return pulumi.get(self, "resource_provider")

    @resource_provider.setter
    def resource_provider(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_provider", value)


class Network(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 resource_provider: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a Network resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cidr_block: Address space of the network in CIDR block notation
        :param pulumi.Input[str] name: Human-friendly name for the network
        :param pulumi.Input[str] project_id: Project ID
        :param pulumi.Input[str] region: Provider region in which to provision the network
        :param pulumi.Input[str] resource_provider: Cloud Provider in which to provision the network.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NetworkArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a Network resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param NetworkArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NetworkArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cidr_block: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 resource_provider: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NetworkArgs.__new__(NetworkArgs)

            if cidr_block is None and not opts.urn:
                raise TypeError("Missing required property 'cidr_block'")
            __props__.__dict__["cidr_block"] = cidr_block
            __props__.__dict__["name"] = name
            if project_id is None and not opts.urn:
                raise TypeError("Missing required property 'project_id'")
            __props__.__dict__["project_id"] = project_id
            if region is None and not opts.urn:
                raise TypeError("Missing required property 'region'")
            __props__.__dict__["region"] = region
            if resource_provider is None and not opts.urn:
                raise TypeError("Missing required property 'resource_provider'")
            __props__.__dict__["resource_provider"] = resource_provider
        super(Network, __self__).__init__(
            'eventstorecloud:index/network:Network',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cidr_block: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project_id: Optional[pulumi.Input[str]] = None,
            region: Optional[pulumi.Input[str]] = None,
            resource_provider: Optional[pulumi.Input[str]] = None) -> 'Network':
        """
        Get an existing Network resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cidr_block: Address space of the network in CIDR block notation
        :param pulumi.Input[str] name: Human-friendly name for the network
        :param pulumi.Input[str] project_id: Project ID
        :param pulumi.Input[str] region: Provider region in which to provision the network
        :param pulumi.Input[str] resource_provider: Cloud Provider in which to provision the network.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NetworkState.__new__(_NetworkState)

        __props__.__dict__["cidr_block"] = cidr_block
        __props__.__dict__["name"] = name
        __props__.__dict__["project_id"] = project_id
        __props__.__dict__["region"] = region
        __props__.__dict__["resource_provider"] = resource_provider
        return Network(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cidrBlock")
    def cidr_block(self) -> pulumi.Output[str]:
        """
        Address space of the network in CIDR block notation
        """
        return pulumi.get(self, "cidr_block")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Human-friendly name for the network
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Output[str]:
        """
        Project ID
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter
    def region(self) -> pulumi.Output[str]:
        """
        Provider region in which to provision the network
        """
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="resourceProvider")
    def resource_provider(self) -> pulumi.Output[str]:
        """
        Cloud Provider in which to provision the network.
        """
        return pulumi.get(self, "resource_provider")
