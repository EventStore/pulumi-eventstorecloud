# Pulumi provider for Event Store Cloud

The Event Store Cloud provider allows you to manage resources in [Event Store Cloud](https://eventstore.com/cloud).

## Installation

This package is available in many languages in the standard packaging formats.

### Configure the provider

The following configuration points are available for the `eventstorecloud` provider:

- `eventstorecloud:organizationId` - the organization ID for an existing organization in Event Store Cloud
- `eventstorecloud:token` - a valid refresh token for an Event Store Cloud account with admin access to the organization

### Install SDK


Install the NodeJS SDK using either `npm`:

```bash
$ npm install @eventstore/pulumi-eventstorecloud
```

or `yarn`:

```bash
$ yarn add @eventstore/pulumi-eventstorecloud
```
