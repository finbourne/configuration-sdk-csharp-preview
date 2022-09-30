/*
 * FINBOURNE ConfigurationService API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.341
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Configuration.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Configuration.Sdk.Model
{
    /// <summary>
    /// The information required to update a configuration item
    /// </summary>
    [DataContract(Name = "UpdateConfigurationItem")]
    public partial class UpdateConfigurationItem : IEquatable<UpdateConfigurationItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigurationItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateConfigurationItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigurationItem" /> class.
        /// </summary>
        /// <param name="value">The new value of the configuration item (required).</param>
        /// <param name="description">The new description of the configuration item.</param>
        public UpdateConfigurationItem(string value = default(string), string description = default(string))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for UpdateConfigurationItem and cannot be null");
            this.Description = description;
        }

        /// <summary>
        /// The new value of the configuration item
        /// </summary>
        /// <value>The new value of the configuration item</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The new description of the configuration item
        /// </summary>
        /// <value>The new description of the configuration item</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConfigurationItem {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConfigurationItem);
        }

        /// <summary>
        /// Returns true if UpdateConfigurationItem instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateConfigurationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateConfigurationItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
