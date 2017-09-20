// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class that describes the reason for a validation failure.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetValidationFailureDetails : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetValidationFailureDetails
        /// class.
        /// </summary>
        public VnetValidationFailureDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetValidationFailureDetails
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="failed">A flag describing whether or not validation
        /// failed.</param>
        /// <param name="failedTests">A list of tests that failed in the
        /// validation.</param>
        public VnetValidationFailureDetails(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? failed = default(bool?), IList<VnetValidationTestFailure> failedTests = default(IList<VnetValidationTestFailure>))
            : base(id, name, kind, type)
        {
            Failed = failed;
            FailedTests = failedTests;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a flag describing whether or not validation failed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failed")]
        public bool? Failed { get; set; }

        /// <summary>
        /// Gets or sets a list of tests that failed in the validation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failedTests")]
        public IList<VnetValidationTestFailure> FailedTests { get; set; }

    }
}