﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DotNet.Build.Tasks.Workloads {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DotNet.Build.Tasks.Workloads.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extracting package: {0}..
        /// </summary>
        internal static string BuildExtractingPackage {
            get {
                return ResourceManager.GetString("BuildExtractingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to extract the manifest ID from the package ID: {0}..
        /// </summary>
        internal static string CannotExtractManifestIdFromPackageId {
            get {
                return ResourceManager.GetString("CannotExtractManifestIdFromPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to extract the SDK version from the package ID: {0}..
        /// </summary>
        internal static string CannotExtractSdkVersionFromPackageId {
            get {
                return ResourceManager.GetString("CannotExtractSdkVersionFromPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Components cannot have a null description. Either provide a custom resource or add a description to the workload definition..
        /// </summary>
        internal static string ComponentDescriptionCannotBeNull {
            get {
                return ResourceManager.GetString("ComponentDescriptionCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SWIX component must have at least one dependency, Id: {0}..
        /// </summary>
        internal static string ComponentMustHaveAtLeastOneDependency {
            get {
                return ResourceManager.GetString("ComponentMustHaveAtLeastOneDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Components cannot have a null title. Either provide a custom resource or add a description to the workload definition..
        /// </summary>
        internal static string ComponentTitleCannotBeNull {
            get {
                return ResourceManager.GetString("ComponentTitleCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to compile MSI. .
        /// </summary>
        internal static string FailedToCompileMsi {
            get {
                return ResourceManager.GetString("FailedToCompileMsi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to link MSI..
        /// </summary>
        internal static string FailedToLinkMsi {
            get {
                return ResourceManager.GetString("FailedToLinkMsi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to harvest package contents..
        /// </summary>
        internal static string HeatFailedToHarvest {
            get {
                return ResourceManager.GetString("HeatFailedToHarvest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the version of the manifest installer. The {0} task should either provide  a value for the {1} parameter, or the {2} items should set the {3} metadata..
        /// </summary>
        internal static string NoManifestInstallerVersion {
            get {
                return ResourceManager.GetString("NoManifestInstallerVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Relative package path exceeds the maximum length ({0}): {1}. .
        /// </summary>
        internal static string RelativePackagePathTooLong {
            get {
                return ResourceManager.GetString("RelativePackagePathTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum version must be greater than or equal to the minimum version, or null. .
        /// </summary>
        internal static string SwixDependencyMaxVersionLessThanMinVersion {
            get {
                return ResourceManager.GetString("SwixDependencyMaxVersionLessThanMinVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SWIX dependency must have a version boundary. The minimum and maximum versions cannot both be null..
        /// </summary>
        internal static string SwixDependencyVersionRequired {
            get {
                return ResourceManager.GetString("SwixDependencyVersionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a template matching the provided key: {0}..
        /// </summary>
        internal static string TemplateNotFound {
            get {
                return ResourceManager.GetString("TemplateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not read the template resource: {0}..
        /// </summary>
        internal static string TemplateResourceNotFound {
            get {
                return ResourceManager.GetString("TemplateResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown workload kind: {0}..
        /// </summary>
        internal static string UnknownWorkloadKind {
            get {
                return ResourceManager.GetString("UnknownWorkloadKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not support any Windows platforms and will be skipped. Supported platforms: {1}..
        /// </summary>
        internal static string WorkloadDefinitionDoesNotSupportWindows {
            get {
                return ResourceManager.GetString("WorkloadDefinitionDoesNotSupportWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the workload manifest. Neither &apos;{0}&apos; nor &apos;{1}&apos; exists..
        /// </summary>
        internal static string WorkloadManifestNotFound {
            get {
                return ResourceManager.GetString("WorkloadManifestNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting &apos;{0}&apos; because it is excluded..
        /// </summary>
        internal static string WorkloadPackageDeleteExclusion {
            get {
                return ResourceManager.GetString("WorkloadPackageDeleteExclusion", resourceCulture);
            }
        }
    }
}
