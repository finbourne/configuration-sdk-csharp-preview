/*
 * FINBOURNE ConfigurationService API
 *
 * The Configuration Store serves as a central repository for securely storing and managing LUSID secrets and parameters, enabling seamless integration and secure secret sharing within a LUSID environment.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.1.559
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
    /// ResourceListOfConfigurationItem
    /// </summary>
    [DataContract(Name = "ResourceListOfConfigurationItem")]
    public partial class ResourceListOfConfigurationItem : IEquatable<ResourceListOfConfigurationItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListOfConfigurationItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceListOfConfigurationItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListOfConfigurationItem" /> class.
        /// </summary>
        /// <param name="values">values (required).</param>
        /// <param name="href">href.</param>
        /// <param name="links">links.</param>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="previousPage">previousPage.</param>
        public ResourceListOfConfigurationItem(List<ConfigurationItem> values = default(List<ConfigurationItem>), string href = default(string), List<Link> links = default(List<Link>), string nextPage = default(string), string previousPage = default(string))
        {
            // to ensure "values" is required (not null)
            this.Values = values ?? throw new ArgumentNullException("values is a required property for ResourceListOfConfigurationItem and cannot be null");
            this.Href = href;
            this.Links = links;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
        }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = false)]
        public List<ConfigurationItem> Values { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name = "nextPage", EmitDefaultValue = true)]
        public string NextPage { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name = "previousPage", EmitDefaultValue = true)]
        public string PreviousPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceListOfConfigurationItem {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
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
            return this.Equals(input as ResourceListOfConfigurationItem);
        }

        /// <summary>
        /// Returns true if ResourceListOfConfigurationItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceListOfConfigurationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceListOfConfigurationItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PreviousPage == input.PreviousPage ||
                    (this.PreviousPage != null &&
                    this.PreviousPage.Equals(input.PreviousPage))
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hashCode = hashCode * 59 + this.PreviousPage.GetHashCode();
                return hashCode;
            }
        }

    }
}
