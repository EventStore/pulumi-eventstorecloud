// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Creates a new scheduled backup.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as eventstorecloud from "@eventstore/pulumi-eventstorecloud";
 *
 * const daily = new eventstorecloud.ScheduledBackup("daily", {
 *     projectId: eventstorecloud_project.example.id,
 *     schedule: "0 12 * * *&#47;1",
 *     description: "Creates a backup once a day at 12:00",
 *     sourceClusterId: eventstorecloud_managed_cluster.example.id,
 *     backupDescription: "{cluster} Daily Backup {datetime:RFC3339}",
 *     maxBackupCount: 3,
 * });
 * ```
 *
 * ## Import
 *
 * ```sh
 *  $ pulumi import eventstorecloud:index/scheduledBackup:ScheduledBackup daily project_id:backup_id
 * ```
 */
export class ScheduledBackup extends pulumi.CustomResource {
    /**
     * Get an existing ScheduledBackup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ScheduledBackupState, opts?: pulumi.CustomResourceOptions): ScheduledBackup {
        return new ScheduledBackup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'eventstorecloud:index/scheduledBackup:ScheduledBackup';

    /**
     * Returns true if the given object is an instance of ScheduledBackup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScheduledBackup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScheduledBackup.__pulumiType;
    }

    /**
     * backup_description
     */
    public readonly backupDescription!: pulumi.Output<string>;
    /**
     * Human readable description of the job
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * The maximum number of backups to keep for this job
     */
    public readonly maxBackupCount!: pulumi.Output<number>;
    /**
     * ID of the project in which the backup exists
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * Schedule for the backup, defined using restricted subset of cron
     */
    public readonly schedule!: pulumi.Output<string>;
    /**
     * the ID of the cluster to back up
     */
    public readonly sourceClusterId!: pulumi.Output<string>;

    /**
     * Create a ScheduledBackup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ScheduledBackupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ScheduledBackupArgs | ScheduledBackupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ScheduledBackupState | undefined;
            resourceInputs["backupDescription"] = state ? state.backupDescription : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["maxBackupCount"] = state ? state.maxBackupCount : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["schedule"] = state ? state.schedule : undefined;
            resourceInputs["sourceClusterId"] = state ? state.sourceClusterId : undefined;
        } else {
            const args = argsOrState as ScheduledBackupArgs | undefined;
            if ((!args || args.backupDescription === undefined) && !opts.urn) {
                throw new Error("Missing required property 'backupDescription'");
            }
            if ((!args || args.description === undefined) && !opts.urn) {
                throw new Error("Missing required property 'description'");
            }
            if ((!args || args.maxBackupCount === undefined) && !opts.urn) {
                throw new Error("Missing required property 'maxBackupCount'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            if ((!args || args.schedule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'schedule'");
            }
            if ((!args || args.sourceClusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceClusterId'");
            }
            resourceInputs["backupDescription"] = args ? args.backupDescription : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["maxBackupCount"] = args ? args.maxBackupCount : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["schedule"] = args ? args.schedule : undefined;
            resourceInputs["sourceClusterId"] = args ? args.sourceClusterId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ScheduledBackup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ScheduledBackup resources.
 */
export interface ScheduledBackupState {
    /**
     * backup_description
     */
    backupDescription?: pulumi.Input<string>;
    /**
     * Human readable description of the job
     */
    description?: pulumi.Input<string>;
    /**
     * The maximum number of backups to keep for this job
     */
    maxBackupCount?: pulumi.Input<number>;
    /**
     * ID of the project in which the backup exists
     */
    projectId?: pulumi.Input<string>;
    /**
     * Schedule for the backup, defined using restricted subset of cron
     */
    schedule?: pulumi.Input<string>;
    /**
     * the ID of the cluster to back up
     */
    sourceClusterId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ScheduledBackup resource.
 */
export interface ScheduledBackupArgs {
    /**
     * backup_description
     */
    backupDescription: pulumi.Input<string>;
    /**
     * Human readable description of the job
     */
    description: pulumi.Input<string>;
    /**
     * The maximum number of backups to keep for this job
     */
    maxBackupCount: pulumi.Input<number>;
    /**
     * ID of the project in which the backup exists
     */
    projectId: pulumi.Input<string>;
    /**
     * Schedule for the backup, defined using restricted subset of cron
     */
    schedule: pulumi.Input<string>;
    /**
     * the ID of the cluster to back up
     */
    sourceClusterId: pulumi.Input<string>;
}
