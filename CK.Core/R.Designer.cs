﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CK.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class R {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal R() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CK.Core.R", typeof(R).Assembly);
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
        ///   Looks up a localized string similar to A &apos;{0}&apos; can be registered in only one IActivityMonitor.Output at the same time. Unregister it before Registering it in another monitor..
        /// </summary>
        internal static string ActivityMonitorBoundClientMultipleRegister {
            get {
                return ResourceManager.GetString("ActivityMonitorBoundClientMultipleRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Concurrent accesses from 2 threads to the same ActivityMonitor has been detected. Only one thread at a time can interact with an ActivityMonitor..
        /// </summary>
        internal static string ActivityMonitorConcurrentThreadAccess {
            get {
                return ResourceManager.GetString("ActivityMonitorConcurrentThreadAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected error while getting conclusion text: &apos;{0}&apos;..
        /// </summary>
        internal static string ActivityMonitorErrorWhileGetConclusionText {
            get {
                return ResourceManager.GetString("ActivityMonitorErrorWhileGetConclusionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The level must be a valid level (Trace, Info, Warn, Error or Fatal)..
        /// </summary>
        internal static string ActivityMonitorInvalidLogLevel {
            get {
                return ResourceManager.GetString("ActivityMonitorInvalidLogLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only reentrant calls to this method are supported..
        /// </summary>
        internal static string ActivityMonitorReentrancyCallOnly {
            get {
                return ResourceManager.GetString("ActivityMonitorReentrancyCallOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A reentrant call in an ActivityMonitor has been detected. A monitor usage must not trigger another operation on the same monitor..
        /// </summary>
        internal static string ActivityMonitorReentrancyError {
            get {
                return ResourceManager.GetString("ActivityMonitorReentrancyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal error: Error during release reentrancy operation. Thread id={0} entered whereas release is called from thread &apos;{1}&apos;, id={2}..
        /// </summary>
        internal static string ActivityMonitorReentrancyReleaseError {
            get {
                return ResourceManager.GetString("ActivityMonitorReentrancyReleaseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Tag (CKTrait) must be registered in ActivityMonitor.Tags..
        /// </summary>
        internal static string ActivityMonitorTagMustBeRegistered {
            get {
                return ResourceManager.GetString("ActivityMonitorTagMustBeRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependent token created by Monitor &apos;{0}&apos; at {1} expect at most {2} dependent activitiy(es)..
        /// </summary>
        internal static string ActivityMonitorTooMuchDependentStart {
            get {
                return ResourceManager.GetString("ActivityMonitorTooMuchDependentStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AggregatedExceptions must contain at least one exception..
        /// </summary>
        internal static string AggregatedExceptionsMustContainAtLeastOne {
            get {
                return ResourceManager.GetString("AggregatedExceptionsMustContainAtLeastOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApplicationSettings have already been initialized.It can be initialized only once..
        /// </summary>
        internal static string AppSettingsAlreadyInitialized {
            get {
                return ResourceManager.GetString("AppSettingsAlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to initialize AppSettings, the default fallback to System.Configuration.ConfigurationManager.AppSettings can not be generated since System.Configuration assembly is not available..
        /// </summary>
        internal static string AppSettingsDefaultInitializationFailed {
            get {
                return ResourceManager.GetString("AppSettingsDefaultInitializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required AppSettings configuration named &apos;{0}&apos; is missising: it must be a &apos;{1}&apos;..
        /// </summary>
        internal static string AppSettingsRequiredConfigurationBadType {
            get {
                return ResourceManager.GetString("AppSettingsRequiredConfigurationBadType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required AppSettings configuration named &apos;{0}&apos; is missising..
        /// </summary>
        internal static string AppSettingsRequiredConfigurationMissing {
            get {
                return ResourceManager.GetString("AppSettingsRequiredConfigurationMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument count can not be negative..
        /// </summary>
        internal static string ArgumentCountNegative {
            get {
                return ResourceManager.GetString("ArgumentCountNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument must not be null or whitespace..
        /// </summary>
        internal static string ArgumentMustNotBeNullOrWhiteSpace {
            get {
                return ResourceManager.GetString("ArgumentMustNotBeNullOrWhiteSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prematurely closed by Bridge removed..
        /// </summary>
        internal static string ClosedByBridgeRemoved {
            get {
                return ResourceManager.GetString("ClosedByBridgeRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DateTime must be Utc. Use DateTime.UtcNow to obtain it for instance..
        /// </summary>
        internal static string DateTimeMustBeUtc {
            get {
                return ResourceManager.GetString("DateTimeMustBeUtc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is direcly supported by the container. It can not be disabled..
        /// </summary>
        internal static string DirectServicesCanNotBeDisabled {
            get {
                return ResourceManager.GetString("DirectServicesCanNotBeDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error handler raised the error. It has been removed from the CriticalErrorCollector.OnErrorFromBackgroundThreads event..
        /// </summary>
        internal static string ErrorWhileCollectorRaiseError {
            get {
                return ResourceManager.GetString("ErrorWhileCollectorRaiseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occured while resolving type: {0}..
        /// </summary>
        internal static string ExceptionWhileResolvingType {
            get {
                return ResourceManager.GetString("ExceptionWhileResolvingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected attribute &apos;{0}&apos;..
        /// </summary>
        internal static string ExpectedXmlAttribute {
            get {
                return ResourceManager.GetString("ExpectedXmlAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected EndElement token named {0}..
        /// </summary>
        internal static string ExpectedXmlEndElement {
            get {
                return ResourceManager.GetString("ExpectedXmlEndElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;factory&apos; function must create an item that satisfies the &apos;tester&apos; function..
        /// </summary>
        internal static string FactoryTesterMismatch {
            get {
                return ResourceManager.GetString("FactoryTesterMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FIFOBuffer is empty..
        /// </summary>
        internal static string FIFOBufferEmpty {
            get {
                return ResourceManager.GetString("FIFOBufferEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File must exist..
        /// </summary>
        internal static string FileMustExist {
            get {
                return ResourceManager.GetString("FileMustExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access set to FileAccess.Read is stupid when creating a file..
        /// </summary>
        internal static string FileUtilNoReadOnlyWhenCreateFile {
            get {
                return ResourceManager.GetString("FileUtilNoReadOnlyWhenCreateFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create a unique timed file..
        /// </summary>
        internal static string FileUtilUnableToCreateUniqueTimedFile {
            get {
                return ResourceManager.GetString("FileUtilUnableToCreateUniqueTimedFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The InnerException must be the first AggregatedExceptions..
        /// </summary>
        internal static string InnerExceptionMustBeTheFirstAggregatedException {
            get {
                return ResourceManager.GetString("InnerExceptionMustBeTheFirstAggregatedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is not a valid assembly qualified name..
        /// </summary>
        internal static string InvalidAssemblyQualifiedName {
            get {
                return ResourceManager.GetString("InvalidAssemblyQualifiedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {2} = &apos;{0}&apos; is invalid: unable to create a test file in &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidRootLogPath {
            get {
                return ResourceManager.GetString("InvalidRootLogPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to refObject Must be a MarshalByRefObject..
        /// </summary>
        internal static string MustBeAMarshalByRefObject {
            get {
                return ResourceManager.GetString("MustBeAMarshalByRefObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Possible use of the wrong overload: Use the form that takes a first parameter of type Exception and then the string text instead of this ( string format, object arg0, ... ) method to log the exception, or calls this overload explicitely with the Exception.Message string..
        /// </summary>
        internal static string PossibleWrongOverloadUseWithException {
            get {
                return ResourceManager.GetString("PossibleWrongOverloadUseWithException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be set to a valid, writeable, folder. You can set it programmatically at the start of your program or use the &lt;appSettings&gt; section of the application config file: &lt;configuration&gt;\r\n &lt;appSettings&gt;\r\n  &lt;add key=&quot;{0}&quot; value=&quot;(path)&quot; /&gt;\r\n &lt;/appSettings&gt;\r\n&lt;/configuration&gt;.
        /// </summary>
        internal static string RootLogPathMustBeSet {
            get {
                return ResourceManager.GetString("RootLogPathMustBeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is directly supported by the container..
        /// </summary>
        internal static string ServiceAlreadyDirectlySupported {
            get {
                return ResourceManager.GetString("ServiceAlreadyDirectlySupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is already registered by the container..
        /// </summary>
        internal static string ServiceAlreadyRegistered {
            get {
                return ResourceManager.GetString("ServiceAlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is not implemented by object {1} returned by the callback..
        /// </summary>
        internal static string ServiceImplCallbackTypeMismatch {
            get {
                return ResourceManager.GetString("ServiceImplCallbackTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service {0} is not implemented by object {1}..
        /// </summary>
        internal static string ServiceImplTypeMismatch {
            get {
                return ResourceManager.GetString("ServiceImplTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One of the action is null..
        /// </summary>
        internal static string SimpleMultiActionNullAction {
            get {
                return ResourceManager.GetString("SimpleMultiActionNullAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SystemActivityMonitor.RootLogPath must be set only once and before any access to it if defined in application config (in the AppSettings section)..
        /// </summary>
        internal static string SystemActivityMonitorRootLogPathSetOnlyOnce {
            get {
                return ResourceManager.GetString("SystemActivityMonitorRootLogPathSetOnlyOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Traits must belong to the same context..
        /// </summary>
        internal static string TraitsMustBelongToTheSameContext {
            get {
                return ResourceManager.GetString("TraitsMustBelongToTheSameContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find service &apos;{0}&apos;..
        /// </summary>
        internal static string UnregisteredServiceInServiceProvider {
            get {
                return ResourceManager.GetString("UnregisteredServiceInServiceProvider", resourceCulture);
            }
        }
    }
}
