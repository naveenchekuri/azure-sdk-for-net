// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An access policy entry.
    /// </summary>
    public partial class ServiceAccessPolicyEntry
    {
        /// <summary>
        /// Initializes a new instance of the ServiceAccessPolicyEntry class.
        /// </summary>
        public ServiceAccessPolicyEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceAccessPolicyEntry class.
        /// </summary>
        /// <param name="objectId">An object ID that is allowed access to the
        /// FHIR service.</param>
        public ServiceAccessPolicyEntry(string objectId)
        {
            ObjectId = objectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object ID that is allowed access to the FHIR
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ObjectId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectId");
            }
            if (ObjectId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ObjectId, "^(([0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}){1})+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ObjectId", "^(([0-9A-Fa-f]{8}[-]?(?:[0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}){1})+$");
                }
            }
        }
    }
}
