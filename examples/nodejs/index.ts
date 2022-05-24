import * as pulumi from "@pulumi/pulumi";
import * as esc from "@eventstore/pulumi-eventstorecloud";
import * as awsx from "@pulumi/awsx";
import * as aws from "@pulumi/aws";

const awsConfig = new pulumi.Config("aws");

const vpc = new awsx.ec2.Vpc("example", {
    cidrBlock: "172.250.0.0/24",
    numberOfAvailabilityZones: 3
});

const project = new esc.Project("sample-project", {
    name: "Improved Chicken Window"
});

const network = new esc.Network("sample-network", {
    name: "Chicken Window Net",
    projectId: project.id,
    resourceProvider: "aws",
    region: awsConfig.require("region"),
    cidrBlock: "172.21.0.0/16"
});

const peering = new esc.Peering("sample-peering", {
    name: "Sample Peering",
    projectId: project.id,
    networkId: network.id,
    peerResourceProvider: network.resourceProvider,
    peerNetworkRegion: network.region,
    peerAccountId: vpc.vpc.ownerId,
    peerNetworkId: vpc.vpcId,
    routes: [vpc.vpc.cidrBlock]
});

const peer = new aws.ec2.VpcPeeringConnectionAccepter("sample-accept", {
    vpcPeeringConnectionId: peering.providerMetadata["aws_peering_link_id"],
    autoAccept: true,
    tags: {
        Side: "Accepter",
        Source: "Event Store"
    }
});

const route = new aws.ec2.Route("route", {
    vpcPeeringConnectionId: peer.id,
    routeTableId: vpc.vpc.mainRouteTableId,
    destinationCidrBlock: network.cidrBlock
});

const cluster = new esc.ManagedCluster("wings", {
    // name: "Wings Cluster",
    projectId: project.id,
    networkId: network.id,
    topology: "single-node",
    instanceType: "F1",
    diskSize: 16,
    diskType: "gp3",
    serverVersion: "21.10"
});

export let clusterDnsName = cluster.dnsName;
