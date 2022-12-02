// Copyright 2022, Event Store Ltd
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package eventstorecloud

import (
	"fmt"
	"path/filepath"
	"strings"
	"unicode"

	"github.com/EventStore/pulumi-eventstorecloud/provider/pkg/version"
	"github.com/EventStore/terraform-provider-eventstorecloud/esc"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"github.com/pulumi/pulumi/sdk/v3/go/common/tokens"
)

const (
	mainPkg = "eventstorecloud"
	mainMod = "index"
)

var namespaceMap = map[string]string{
	"eventstorecloud": "EventStoreCloud",
}

// makeMember manufactures a type token for the package and the given module and type.
func makeMember(mod string, mem string) tokens.ModuleMember {
	moduleName := strings.ToLower(mod)
	namespaceMap[moduleName] = mod
	fn := string(unicode.ToLower(rune(mem[0]))) + mem[1:]
	token := moduleName + "/" + fn
	return tokens.ModuleMember(mainPkg + ":" + token + ":" + mem)
}

// makeType manufactures a type token for the package and the given module and type.
func makeType(mod string, typ string) tokens.Type {
	return tokens.Type(makeMember(mod, typ))
}

// makeDataSource manufactures a standard resource token given a module and resource name.  It
// automatically uses the main package and names the file by simply lower casing the data source's
// first character.
func makeDataSource(mod string, res string) tokens.ModuleMember {
	//fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	//return makeMember(mod+"/"+fn, res)
	return makeMember(mod, res)
}

// makeResource manufactures a standard resource token given a module and resource name.  It
// automatically uses the main package and names the file by simply lower casing the resource's
// first character.
func makeResource(mod string, res string) tokens.Type {
	//fn := string(unicode.ToLower(rune(res[0]))) + res[1:]
	//return makeType(mod+"/"+fn, res)
	return makeType(mod, res)
}

// boolRef returns a reference to the bool argument.
func boolRef(b bool) *bool {
	return &b
}

// stringValue gets a string value from a property map if present, else ""
func stringValue(vars resource.PropertyMap, prop resource.PropertyKey) string {
	val, ok := vars[prop]
	if ok && val.IsString() {
		return val.StringValue()
	}
	return ""
}

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// managedByPulumi is a default used for some managed resources, in the absence of something more meaningful.
var managedByPulumi = &tfbridge.DefaultInfo{Value: "Managed by Pulumi"}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(esc.New("")())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:                    p,
		Name:                 "eventstorecloud",
		DisplayName:          "Event Store Cloud",
		Publisher:            "EventStore",
		Description:          "A Pulumi package for creating and managing Event Store Cloud resources.",
		Keywords:             []string{"pulumi", "eventstorecloud"},
		License:              "Apache-2.0",
		Homepage:             "https://eventstore.com",
		Repository:           "https://github.com/EventStore/pulumi-eventstorecloud",
		GitHubOrg:            "EventStore",
		Config:               map[string]*tfbridge.SchemaInfo{},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			"eventstorecloud_project":                           {Tok: makeResource(mainMod, "Project")},
			"eventstorecloud_network":                           {Tok: makeResource(mainMod, "Network")},
			"eventstorecloud_peering":                           {Tok: makeResource(mainMod, "Peering")},
			"eventstorecloud_managed_cluster":                   {Tok: makeResource(mainMod, "ManagedCluster")},
			"eventstorecloud_scheduled_backup":                  {Tok: makeResource(mainMod, "ScheduledBackup")},
			"eventstorecloud_integration":                       {Tok: makeResource(mainMod, "Integration")},
			"eventstorecloud_integration_awscloudwatch_logs":    {Tok: makeResource(mainMod, "AWSCloudWatchLogsIntegration")},
			"eventstorecloud_integration_awscloudwatch_metrics": {Tok: makeResource(mainMod, "AWSCloudWatchMetricsIntegration")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"eventstorecloud_project": {Tok: makeDataSource(mainMod, "getProject")},
			"eventstorecloud_network": {Tok: makeDataSource(mainMod, "getNetwork")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@eventstore/pulumi-eventstorecloud",
		},
		Python: &tfbridge.PythonInfo{
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/EventStore/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi":                       "3.*",
				"System.Collections.Immutable": "5.0.0",
			},
			Namespaces: namespaceMap,
		},
		PluginDownloadURL: fmt.Sprintf("https://github.com/EventStore/pulumi-eventstorecloud/releases/download/%s", version.Version),
	}

	prov.SetAutonaming(255, "-")

	return prov
}
