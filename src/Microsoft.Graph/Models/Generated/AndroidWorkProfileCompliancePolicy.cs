// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Work Profile Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileCompliancePolicy : DeviceCompliancePolicy
    {
    
        /// <summary>
        /// Gets or sets password required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets security prevent install apps from unknown sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityPreventInstallAppsFromUnknownSources", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityPreventInstallAppsFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets security disable usb debugging.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityDisableUsbDebugging", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityDisableUsbDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireVerifyApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireVerifyApps { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets security block jailbroken devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityBlockJailbrokenDevices", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityBlockJailbrokenDevices { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets min android security patch level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minAndroidSecurityPatchLevel", Required = Newtonsoft.Json.Required.Default)]
        public string MinAndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation basic integrity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationBasicIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation certified device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationCertifiedDevice", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets security require google play services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireGooglePlayServices", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireGooglePlayServices { get; set; }
    
        /// <summary>
        /// Gets or sets security require up to date security providers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireUpToDateSecurityProviders", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireUpToDateSecurityProviders { get; set; }
    
        /// <summary>
        /// Gets or sets security require company portal app integrity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireCompanyPortalAppIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireCompanyPortalAppIntegrity { get; set; }
    
    }
}

