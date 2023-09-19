/*
 * FINBOURNE ConfigurationService API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.464
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
    /// The information required to create a configuration item
    /// </summary>
    [DataContract(Name = "CreateConfigurationItem")]
    public partial class CreateConfigurationItem : IEquatable<CreateConfigurationItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurationItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConfigurationItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConfigurationItem" /> class.
        /// </summary>
        /// <param name="key">The key of the new configuration item (required).</param>
        /// <param name="value">The value of the new configuration item                The maximum size for secrets is 4KB and for text values is 2MB (required).</param>
        /// <param name="valueType">The type (text, number, boolean, textCollection, numberCollection) of the new configuration item&#39;s value.  The validation for each type is as follows:  - text: any value  - number: double (e.g. \&quot;5.5\&quot;)  - boolean: true/false  - textCollection: comma separated list (e.g. \&quot;a,b,c\&quot;)  - numberCollection: comma separated list of doubles (e.g. \&quot;1,2,3\&quot;).</param>
        /// <param name="isSecret">Defines whether or not the value is a secret (required).</param>
        /// <param name="description">The description of the new configuration item.</param>
        public CreateConfigurationItem(string key = default(string), string value = default(string), string valueType = default(string), bool isSecret = default(bool), string description = default(string))
        {
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for CreateConfigurationItem and cannot be null");
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for CreateConfigurationItem and cannot be null");
            this.IsSecret = isSecret;
            this.ValueType = valueType;
            this.Description = description;
        }

        /// <summary>
        /// The key of the new configuration item
        /// </summary>
        /// <value>The key of the new configuration item</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The value of the new configuration item                The maximum size for secrets is 4KB and for text values is 2MB
        /// </summary>
        /// <value>The value of the new configuration item                The maximum size for secrets is 4KB and for text values is 2MB</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The type (text, number, boolean, textCollection, numberCollection) of the new configuration item&#39;s value.  The validation for each type is as follows:  - text: any value  - number: double (e.g. \&quot;5.5\&quot;)  - boolean: true/false  - textCollection: comma separated list (e.g. \&quot;a,b,c\&quot;)  - numberCollection: comma separated list of doubles (e.g. \&quot;1,2,3\&quot;)
        /// </summary>
        /// <value>The type (text, number, boolean, textCollection, numberCollection) of the new configuration item&#39;s value.  The validation for each type is as follows:  - text: any value  - number: double (e.g. \&quot;5.5\&quot;)  - boolean: true/false  - textCollection: comma separated list (e.g. \&quot;a,b,c\&quot;)  - numberCollection: comma separated list of doubles (e.g. \&quot;1,2,3\&quot;)</value>
        [DataMember(Name = "valueType", EmitDefaultValue = true)]
        public string ValueType { get; set; }

        /// <summary>
        /// Defines whether or not the value is a secret
        /// </summary>
        /// <value>Defines whether or not the value is a secret</value>
        [DataMember(Name = "isSecret", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSecret { get; set; }

        /// <summary>
        /// The description of the new configuration item
        /// </summary>
        /// <value>The description of the new configuration item</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConfigurationItem {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  IsSecret: ").Append(IsSecret).Append("\n");
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
            return this.Equals(input as CreateConfigurationItem);
        }

        /// <summary>
        /// Returns true if CreateConfigurationItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConfigurationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConfigurationItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.IsSecret == input.IsSecret ||
                    this.IsSecret.Equals(input.IsSecret)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                hashCode = hashCode * 59 + this.IsSecret.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

    }
}
