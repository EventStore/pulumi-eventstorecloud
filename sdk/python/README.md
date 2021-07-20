# Pulumi provider for Event Store Cloud

## Installing

This package is available in many languages in the standard packaging formats.

### Node.js (Java/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

    $ npm install @eventstore/pulumi-eventstorecloud

or `yarn`:

    $ yarn add @eventstore/pulumi-eventstorecloud

### Python

[WIP]

To use from Python, install using `pip`:

    $ pip install pulumi_xyx

### Go

To use from Go, use `go get` to grab the latest version of the library

    $ go get github.com/EventStore/pulumi-eventstorecloud/sdk/go/...

## Configuration

The following configuration points are available for the `eventstorecloud` provider:

- `eventstorecloud:organizationId` - the organization ID for an existing organization in Event Store Cloud
- `eventstorecloud:token` - a valid refresh token for an Event Store Cloud account with admin access to the organization

## Reference

For detailed reference documentation, please visit [the API docs][1].


[1]: https://www.pulumi.com/docs/reference/pkg/x/
