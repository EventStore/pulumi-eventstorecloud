# Pulumi provider for Event Store Cloud

The Event Store Cloud provider allows you to manage resources in [Event Store Cloud](https://eventstore.com/cloud).

## Installing

This package is available in many languages in the standard packaging formats.

### Get the plugin

For projects that use .NET and Go Pulumi SDK you have to install the provider before trying to update the stack.

Use the following command to add the plugin to your environment:

```
pulumi plugin install resource eventstorecloud [version] \
  --server https://github.com/EventStore/pulumi-eventstorecloud/releases/download/[version]
```

Example:

```
pulumi plugin install resource eventstorecloud v0.2.3 \
  --server https://github.com/EventStore/pulumi-eventstorecloud/releases/download/v0.2.3
```

### Configuration

The following configuration points are available for the `eventstorecloud` provider:

- `eventstorecloud:organizationId` - the organization ID for an existing organization in Event Store Cloud
- `eventstorecloud:token` - a valid refresh token for an Event Store Cloud account with admin access to the organization


### Node.js (Java/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

    $ npm install @eventstore/pulumi-eventstorecloud

or `yarn`:

    $ yarn add @eventstore/pulumi-eventstorecloud

### .NET

Add the NuGet package `Pulumi.EventStoreCloud` to your Pulumi project, which uses the .NET Pulumi SDK.

### Python

[WIP]

### Go

To use from Go, use `go get` to grab the latest version of the library

    $ go get github.com/EventStore/pulumi-eventstorecloud/sdk/go/eventstorecloud

