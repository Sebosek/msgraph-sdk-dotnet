// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedAppClipboardSharingLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppClipboardSharingLevel
    {
    
        /// <summary>
        /// all Apps
        /// </summary>
        AllApps = 0,
	
        /// <summary>
        /// managed Apps With Paste In
        /// </summary>
        ManagedAppsWithPasteIn = 1,
	
        /// <summary>
        /// managed Apps
        /// </summary>
        ManagedApps = 2,
	
        /// <summary>
        /// blocked
        /// </summary>
        Blocked = 3,
	
    }
}
