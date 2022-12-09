module github.com/EventStore/pulumi-eventstorecloud/provider

go 1.16

replace github.com/hashicorp/go-getter => github.com/hashicorp/go-getter v1.4.0

replace github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20211019194827-62530c6537a4

require (
	github.com/EventStore/terraform-provider-eventstorecloud v1.5.21
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.21.0
	github.com/pulumi/pulumi/sdk/v3 v3.30.0
)
