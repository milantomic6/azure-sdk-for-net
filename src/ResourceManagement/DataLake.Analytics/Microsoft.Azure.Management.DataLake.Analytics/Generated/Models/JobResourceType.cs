// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobResourceType.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobResourceType
    {
        [EnumMember(Value = "VertexResource")]
        VertexResource,
        [EnumMember(Value = "JobManagerResource")]
        JobManagerResource,
        [EnumMember(Value = "StatisticsResource")]
        StatisticsResource,
        [EnumMember(Value = "VertexResourceInUserFolder")]
        VertexResourceInUserFolder,
        [EnumMember(Value = "JobManagerResourceInUserFolder")]
        JobManagerResourceInUserFolder,
        [EnumMember(Value = "StatisticsResourceInUserFolder")]
        StatisticsResourceInUserFolder
    }
}


