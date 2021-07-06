using Pulumi;
using Pulumi.Eventstorecloud;

class MyStack : Stack {
    public MyStack() {
        var project = new Project(
            "myProject",
            new ProjectArgs {
                Name = "Test Alexey"
            }
        );

        var network = new Network(
            "myNetwork",
            new NetworkArgs {
                Name             = "Test Network",
                Region           = "europe-west2",
                CidrBlock        = "172.22.110.0/24",
                ProjectId        = project.Id,
                ResourceProvider = "gcp"
            }
        );

        var cluster = new ManagedCluster(
            "myCluster",
            new ManagedClusterArgs {
                Name            = "Test Cluster",
                ProjectId       = project.Id,
                NetworkId       = network.Id,
                Topology        = "single-node",
                InstanceType    = "F1",
                DiskSize        = 10,
                DiskType        = "ssd",
                ServerVersion   = "20.10",
                ProjectionLevel = "user"
            }
        );
    }
}