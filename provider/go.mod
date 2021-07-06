module github.com/EventStore/pulumi-eventstorecloud/provider

go 1.16

replace github.com/hashicorp/go-getter v1.5.0 => github.com/hashicorp/go-getter v1.4.0

require (
	github.com/EventStore/terraform-provider-eventstorecloud v1.5.4 // indirect
	github.com/hashicorp/terraform-plugin-sdk v1.14.0
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.2.1
	github.com/pulumi/pulumi/sdk/v3 v3.4.0
)
