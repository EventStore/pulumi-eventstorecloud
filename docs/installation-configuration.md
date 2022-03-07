---
title: Event Store Cloud Setup
meta_desc: How to set up credentials to use the Event Store cloud provider for Pulumi.
layout: installation
---

## Installation

The Event Store Cloud provider is available as a package in all Pulumi languages:

* JavaScript/TypeScript: [`@eventstore/pulumi-eventstorecloud`](https://www.npmjs.com/package/@eventstore/pulumi-eventstorecloud)
* Go: [`github.com/EventStore/pulumi-eventstorecloud/sdk/go/eventstorecloud`](https://github.com/EventStore/pulumi-eventstorecloud)
* .NET: [`Pulumi.EventStoreCloud`](https://www.nuget.org/packages/Pulumi.EventStoreCloud)

## Setup

To provision resources with the Event Store Cloud (ESC) provider, you need to have ESC credentials. 

Your ESC credentials are never sent to pulumi.com. Pulumi uses the ESC API and the credentials in your environment to authenticate requests from your computer to ESC.

### Get your credentials

First, you need an [access token](https://console.eventstore.cloud/authentication-tokens) for your user.

Then, go to the list of organizations you have access to in Event Store Cloud console, choose the organization that you will be provisioning resources for, and look the organization id in the settings.

* `<YOUR_ACCESS_TOKEN>`: your access token
* `<YOUR_ORGANIZATION_ID>`: the Event Store Cloud organization id

### Set environment variables

To authenticate using environment variable, set them in your terminal:

{{< chooser os "linux,macos,windows" >}}
{{% choosable os linux %}}

```bash
$ export ESC_TOKEN=<YOUR_ACCESS_TOKEN>
$ export ESC_ORG_ID=<YOUR_ORGANIZATION_ID>
```

{{% /choosable %}}

{{% choosable os macos %}}

```bash
$ export ESC_TOKEN=<YOUR_ACCESS_TOKEN>
$ export ESC_ORG_ID=<YOUR_ORGANIZATION_ID>
```

{{% /choosable %}}

{{% choosable os windows %}}

```powershell
> $env:ESC_TOKEN = "<YOUR_ACCESS_TOKEN>"
> $env:ESC_ORG_ID = "<YOUR_ORGANIZATION_ID>"
```

{{% /choosable %}}
{{< /chooser >}}

## Configuration options

Use `pulumi config set eventstorecloud:<option>` to set the values per stack.

{{% notes "info" %}}
Required options can be omitted if you configure them using environment variables. 
{{% /notes %}}

| Option           | Required/Optional | Description                                                                                             |
|------------------|-------------------|---------------------------------------------------------------------------------------------------------|
| `token`          | Required          | Access token. You can retrieve this from the ‘Access Tokens’ section of the Event Store Cloud console.  |
| `organizationId` | Required          | The organization id. You can find it in the organization settings page if the ESC console.              |
| `url`            | Optional          | The URL of the Event Store Cloud API. This defaults to the public cloud instance of Event Store Cloud.  |
| `tokenStore`     | Optional          | The location on the local filesystem of the token cache. This is shared with the Event Store Cloud CLI. |
