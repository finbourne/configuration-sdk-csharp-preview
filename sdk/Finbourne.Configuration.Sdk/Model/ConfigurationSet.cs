/*
 * FINBOURNE ConfigurationService API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.250
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
    /// The full version of the configuration set
    /// </summary>
    [DataContract(Name = "ConfigurationSet")]
    public partial class ConfigurationSet : IEquatable<ConfigurationSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationSet" /> class.
        /// </summary>
        /// <param name="createdAt">The date referring to the creation date of the configuration set (required).</param>
        /// <param name="createdBy">Who created the configuration set (required).</param>
        /// <param name="lastModifiedAt">The date referring to the date when the configuration set was last modified (required).</param>
        /// <param name="lastModifiedBy">Who modified the configuration set most recently (required).</param>
        /// <param name="description">Describes the configuration set.</param>
        /// <param name="items">The collection of the configuration items that this set contains..</param>
        /// <param name="id">id (required).</param>
        /// <param name="type">The type (personal or shared) of the configuration set (required).</param>
        /// <param name="links">links.</param>
        public ConfigurationSet(DateTimeOffset createdAt = default(DateTimeOffset), string createdBy = default(string), DateTimeOffset lastModifiedAt = default(DateTimeOffset), string lastModifiedBy = default(string), string description = default(string), List<ConfigurationItemSummary> items = default(List<ConfigurationItemSummary>), ResourceId id = default(ResourceId), string type = default(string), List<Link> links = default(List<Link>))
        {
            this.CreatedAt = createdAt;
            // to ensure "createdBy" is required (not null)
            this.CreatedBy = createdBy ?? throw new ArgumentNullException("createdBy is a required property for ConfigurationSet and cannot be null");
            this.LastModifiedAt = lastModifiedAt;
            // to ensure "lastModifiedBy" is required (not null)
            this.LastModifiedBy = lastModifiedBy ?? throw new ArgumentNullException("lastModifiedBy is a required property for ConfigurationSet and cannot be null");
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for ConfigurationSet and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ConfigurationSet and cannot be null");
            this.Description = description;
            this.Items = items;
            this.Links = links;
        }

        /// <summary>
        /// The date referring to the creation date of the configuration set
        /// </summary>
        /// <value>The date referring to the creation date of the configuration set</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Who created the configuration set
        /// </summary>
        /// <value>Who created the configuration set</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date referring to the date when the configuration set was last modified
        /// </summary>
        /// <value>The date referring to the date when the configuration set was last modified</value>
        [DataMember(Name = "lastModifiedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset LastModifiedAt { get; set; }

        /// <summary>
        /// Who modified the configuration set most recently
        /// </summary>
        /// <value>Who modified the configuration set most recently</value>
        [DataMember(Name = "lastModifiedBy", IsRequired = true, EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Describes the configuration set
        /// </summary>
        /// <value>Describes the configuration set</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The collection of the configuration items that this set contains.
        /// </summary>
        /// <value>The collection of the configuration items that this set contains.</value>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<ConfigurationItemSummary> Items { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The type (personal or shared) of the configuration set
        /// </summary>
        /// <value>The type (personal or shared) of the configuration set</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationSet {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModifiedAt: ").Append(LastModifiedAt).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as ConfigurationSet);
        }

        /// <summary>
        /// Returns true if ConfigurationSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModifiedAt == input.LastModifiedAt ||
                    (this.LastModifiedAt != null &&
                    this.LastModifiedAt.Equals(input.LastModifiedAt))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
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
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModifiedAt != null)
                    hashCode = hashCode * 59 + this.LastModifiedAt.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
