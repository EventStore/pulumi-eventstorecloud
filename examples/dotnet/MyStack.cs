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
    }
}