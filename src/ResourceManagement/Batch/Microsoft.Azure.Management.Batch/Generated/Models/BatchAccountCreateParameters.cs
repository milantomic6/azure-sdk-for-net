// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class BatchAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        public BatchAccountCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">The region in which to create the
        /// account.</param>
        /// <param name="tags">The user specified tags associated with the
        /// account.</param>
        /// <param name="autoStorage">The properties related to auto storage
        /// account.</param>
        public BatchAccountCreateParameters(string location, System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), AutoStorageBaseProperties autoStorage = default(AutoStorageBaseProperties))
        {
            Location = location;
            Tags = tags;
            AutoStorage = autoStorage;
        }

        /// <summary>
        /// Gets or sets the region in which to create the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the user specified tags associated with the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the properties related to auto storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageBaseProperties AutoStorage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
            if (this.AutoStorage != null)
            {
                this.AutoStorage.Validate();
            }
        }
    }
}
