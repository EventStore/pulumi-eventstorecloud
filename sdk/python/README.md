# Pulumi provider for Event Store Cloud

The Event Store Cloud provider allows you to manage resources in [Event Store Cloud](https://eventstore.com/cloud).

## Installing

This package is available in many languages in the standard packaging formats.

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

### Configuration

The following configuration points are available for the `eventstorecloud` provider:

- `eventstorecloud:organizationId` - the organization ID for an existing organization in Event Store Cloud
- `eventstorecloud:token` - a valid refresh token for an Event Store Cloud account with admin access to the organization


### Node.js (Java/TypeScript)

First, add the GitHub NPM package source, as the package is not yet available on NPM. Normally, you'd need to include the custom registry to the `.npmrc` file:

```
@eventstore:registry=https://npm.pkg.github.com
```

Read mode about using GitHub NPM registry in [their documentation](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-npm-registry).

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

    $ npm install @eventstore/pulumi-eventstorecloud

or `yarn`:

    $ yarn add @eventstore/pulumi-eventstorecloud

### .NET

Add the GitHub NuGet package registry first, using `dotnet nuget add source` or by specifying it in the `NuGet.config` file. Use `https://nuget.pkg.github.com/EventStore/index.json` as the package feed URL. Read more in the [GitHub documentation](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry).

Then, add the NuGet package `Pulumi.Eventstorecloud` to your Pulumi project, which uses the .NET Pulumi SDK.

### Python

[WIP]

### Go

To use from Go, use `go get` to grab the latest version of the library

    $ go get github.com/EventStore/pulumi-eventstorecloud/sdk/go/eventstorecloud

