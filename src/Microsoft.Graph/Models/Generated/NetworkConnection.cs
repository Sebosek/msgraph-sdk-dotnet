// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type NetworkConnection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class NetworkConnection
    {
    
        /// <summary>
        /// Gets or sets applicationName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationName", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationName { get; set; }
    
        /// <summary>
        /// Gets or sets destinationAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationAddress", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationAddress { get; set; }
    
        /// <summary>
        /// Gets or sets destinationDomain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationDomain", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationDomain { get; set; }
    
        /// <summary>
        /// Gets or sets destinationPort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationPort", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets destinationUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string DestinationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets direction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "direction", Required = Newtonsoft.Json.Required.Default)]
        public ConnectionDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets domainRegisteredDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainRegisteredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets localDnsName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localDnsName", Required = Newtonsoft.Json.Required.Default)]
        public string LocalDnsName { get; set; }
    
        /// <summary>
        /// Gets or sets natDestinationAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natDestinationAddress", Required = Newtonsoft.Json.Required.Default)]
        public string NatDestinationAddress { get; set; }
    
        /// <summary>
        /// Gets or sets natDestinationPort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natDestinationPort", Required = Newtonsoft.Json.Required.Default)]
        public string NatDestinationPort { get; set; }
    
        /// <summary>
        /// Gets or sets natSourceAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natSourceAddress", Required = Newtonsoft.Json.Required.Default)]
        public string NatSourceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets natSourcePort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "natSourcePort", Required = Newtonsoft.Json.Required.Default)]
        public string NatSourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocol", Required = Newtonsoft.Json.Required.Default)]
        public SecurityNetworkProtocol? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets riskScore.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskScore", Required = Newtonsoft.Json.Required.Default)]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets sourceAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SourceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets sourcePort.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourcePort", Required = Newtonsoft.Json.Required.Default)]
        public string SourcePort { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ConnectionStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets urlParameters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlParameters", Required = Newtonsoft.Json.Required.Default)]
        public string UrlParameters { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
