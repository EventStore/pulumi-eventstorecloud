# Pulumi provider for Event Store Cloud

The Event Store Cloud provider allows you to manage resources in [Event Store Cloud](https://eventstore.com/cloud).

## Installation

This package is available in many languages in the standard packaging formats.

### Configure the provider

The following configuration points are available for the `eventstorecloud` provider:

- `eventstorecloud:organizationId` - the organization ID for an existing organization in Event Store Cloud
- `eventstorecloud:token` - a valid refresh token for an Event Store Cloud account with admin access to the organization

### Install SDK


Use `go get` to grab the latest version of the library

```bash
$ go get github.com/EventStore/pulumi-eventstorecloud/sdk/go/eventstorecloud
```

### Get the plugin

For projects that use .NET and Go Pulumi SDK you have to install the provider before trying to update the stack.

Use the following command to add the plugin to your environment:

```
pulumi plugin install resource eventstorecloud v[version] \
  --server https://github.com/EventStore/pulumi-eventstorecloud/releases/download/[version]
```

Example:

```
pulumi plugin install resource eventstorecloud v0.1.2 \
  --server https://github.com/EventStore/pulumi-eventstorecloud/releases/download/0.1.2
```
