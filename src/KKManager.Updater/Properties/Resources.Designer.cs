﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KKManager.Updater.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KKManager.Updater.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap aichika {
            get {
                object obj = ResourceManager.GetObject("aichika", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap chikajump {
            get {
                object obj = ResourceManager.GetObject("chikajump", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Everything is up to date!.
        /// </summary>
        internal static string ModUpdateProgress_AllUpToDate {
            get {
                return ResourceManager.GetString("ModUpdateProgress_AllUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Average download speed: {0}/s).
        /// </summary>
        internal static string ModUpdateProgress_DownloadFinished_Average {
            get {
                return ResourceManager.GetString("ModUpdateProgress_DownloadFinished_Average", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seeding {0}/s to {1} peers (Click OK to stop).
        /// </summary>
        internal static string ModUpdateProgress_DownloadFinished_Seeding {
            get {
                return ResourceManager.GetString("ModUpdateProgress_DownloadFinished_Seeding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloaded {0} out of {1} in {2}.
        /// </summary>
        internal static string ModUpdateProgress_DownloadFinishedStats {
            get {
                return ResourceManager.GetString("ModUpdateProgress_DownloadFinishedStats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading updates....
        /// </summary>
        internal static string ModUpdateProgress_Downloading {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Downloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update was cancelled by the user..
        /// </summary>
        internal static string ModUpdateProgress_Failed_CancelledByUser {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Failed_CancelledByUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KK Manager needs to be updated to get updates..
        /// </summary>
        internal static string ModUpdateProgress_Failed_Outdated {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Failed_Outdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected crash while updating mods, aborting..
        /// </summary>
        internal static string ModUpdateProgress_Failed_Unexpected {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Failed_Unexpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something unexpected happened and the update could not be completed. Make sure that your internet connection is stable, and that you did not hit your download limits, then try again.
        ///
        ///Error message (check log for more):
        ///{0}.
        /// </summary>
        internal static string ModUpdateProgress_Failed_Unexpected_Message {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Failed_Unexpected_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update failed.
        /// </summary>
        internal static string ModUpdateProgress_Failed_Unexpected_Title {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Failed_Unexpected_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reason(s) for failing:.
        /// </summary>
        internal static string ModUpdateProgress_Finished_FailReasons {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Finished_FailReasons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update {0} files because some sources crashed. Check log for details..
        /// </summary>
        internal static string ModUpdateProgress_Finished_Fails {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Finished_Fails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully updated/removed {0} files from {1} tasks..
        /// </summary>
        internal static string ModUpdateProgress_Finished_Main {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Finished_Main", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished updating.
        /// </summary>
        internal static string ModUpdateProgress_Finished_Title {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Finished_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finishing the update process, please wait....
        /// </summary>
        internal static string ModUpdateProgress_Finishing {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Finishing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing was downloaded.
        /// </summary>
        internal static string ModUpdateProgress_NothingWasDownloaded {
            get {
                return ResourceManager.GetString("ModUpdateProgress_NothingWasDownloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OK.
        /// </summary>
        internal static string ModUpdateProgress_OKbutton {
            get {
                return ResourceManager.GetString("ModUpdateProgress_OKbutton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait, this might take a few minutes..
        /// </summary>
        internal static string ModUpdateProgress_PleaseWait {
            get {
                return ResourceManager.GetString("ModUpdateProgress_PleaseWait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It can take over 10 minutes when P2P is enabled..
        /// </summary>
        internal static string ModUpdateProgress_PleaseWait_P2P {
            get {
                return ResourceManager.GetString("ModUpdateProgress_PleaseWait_P2P", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing....
        /// </summary>
        internal static string ModUpdateProgress_Preparing {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Preparing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searching for mod updates....
        /// </summary>
        internal static string ModUpdateProgress_Searching {
            get {
                return ResourceManager.GetString("ModUpdateProgress_Searching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This could take a minute..
        /// </summary>
        internal static string ModUpdateProgress_ThisCouldTakeAMinute {
            get {
                return ResourceManager.GetString("ModUpdateProgress_ThisCouldTakeAMinute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found {0} update tasks ({1} were already up-to-date), waiting for user confirmation..
        /// </summary>
        internal static string ModUpdateProgress_UpdatesFoundConfirmation {
            get {
                return ResourceManager.GetString("ModUpdateProgress_UpdatesFoundConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All mods are up to date!.
        /// </summary>
        internal static string ModUpdateSelect_AllUpToDate {
            get {
                return ResourceManager.GetString("ModUpdateSelect_AllUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get updates.
        /// </summary>
        internal static string ModUpdateSelect_FailedMessage_Title {
            get {
                return ResourceManager.GetString("ModUpdateSelect_FailedMessage_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a task to view its details..
        /// </summary>
        internal static string ModUpdateSelect_SelectTaskToView {
            get {
                return ResourceManager.GetString("ModUpdateSelect_SelectTaskToView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} to download.
        /// </summary>
        internal static string ModUpdateSelect_SizeStatus_BytesToDownload {
            get {
                return ResourceManager.GetString("ModUpdateSelect_SizeStatus_BytesToDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to download.
        /// </summary>
        internal static string ModUpdateSelect_SizeStatus_Nothing {
            get {
                return ResourceManager.GetString("ModUpdateSelect_SizeStatus_Nothing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Will be removed.
        /// </summary>
        internal static string ModUpdateSelect_WillBeRemoved {
            get {
                return ResourceManager.GetString("ModUpdateSelect_WillBeRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create file in directory {0} because of a security issue - {1}
        ///
        ///Do you want KK Manager to attempt to fix the issue? Click cancel if you want to abort..
        /// </summary>
        internal static string SecurityExceptionRetry_Message {
            get {
                return ResourceManager.GetString("SecurityExceptionRetry_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not apply update.
        /// </summary>
        internal static string SecurityExceptionRetry_Title {
            get {
                return ResourceManager.GetString("SecurityExceptionRetry_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://enj.tvguhohfrepbagrag.pbz/VyyhfvbaZbqf/XXZnantre/znfgre/fep/XXZnantre.Hcqngre/fbheprf.config.
        /// </summary>
        internal static string UpdateSourcesUrl {
            get {
                return ResourceManager.GetString("UpdateSourcesUrl", resourceCulture);
            }
        }
    }
}
