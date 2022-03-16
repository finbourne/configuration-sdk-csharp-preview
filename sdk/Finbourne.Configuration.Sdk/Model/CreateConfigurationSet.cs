/*
 * FINBOURNE ConfigurationService API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.214
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
    /// The information required to create a new configuration set
    /// </summary>
    [DataContract(Name = "CreateConfigurationSet")]
    public partial class CreateConfigurationSet : IEquatable<CreateConfigurationSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurationSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConfigurationSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurationSet" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="type">The type (personal or shared) of the new configuration set (required).</param>
        /// <param name="description">The description of the new configuration set.</param>
        public CreateConfigurationSet(ResourceId id = default(ResourceId), string type = default(string), string description = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for CreateConfigurationSet and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CreateConfigurationSet and cannot be null");
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The type (personal or shared) of the new configuration set
        /// </summary>
        /// <value>The type (personal or shared) of the new configuration set</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The description of the new configuration set
        /// </summary>
        /// <value>The description of the new configuration set</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConfigurationSet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateConfigurationSet);
        }

        /// <summary>
        /// Returns true if CreateConfigurationSet instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConfigurationSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConfigurationSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
