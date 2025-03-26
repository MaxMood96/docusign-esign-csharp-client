/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// ConnectionInstance
    /// </summary>
    [DataContract]
    public partial class ConnectionInstance :  IEquatable<ConnectionInstance>, IValidatableObject
    {
        public ConnectionInstance()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionInstance" /> class.
        /// </summary>
        /// <param name="ConnectionKey">ConnectionKey.</param>
        /// <param name="ConnectionValue">ConnectionValue.</param>
        public ConnectionInstance(string ConnectionKey = default(string), string ConnectionValue = default(string))
        {
            this.ConnectionKey = ConnectionKey;
            this.ConnectionValue = ConnectionValue;
        }
        
        /// <summary>
        /// Gets or Sets ConnectionKey
        /// </summary>
        [DataMember(Name="connectionKey", EmitDefaultValue=false)]
        public string ConnectionKey { get; set; }
        /// <summary>
        /// Gets or Sets ConnectionValue
        /// </summary>
        [DataMember(Name="connectionValue", EmitDefaultValue=false)]
        public string ConnectionValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionInstance {\n");
            sb.Append("  ConnectionKey: ").Append(ConnectionKey).Append("\n");
            sb.Append("  ConnectionValue: ").Append(ConnectionValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConnectionInstance);
        }

        /// <summary>
        /// Returns true if ConnectionInstance instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectionInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionInstance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectionKey == other.ConnectionKey ||
                    this.ConnectionKey != null &&
                    this.ConnectionKey.Equals(other.ConnectionKey)
                ) && 
                (
                    this.ConnectionValue == other.ConnectionValue ||
                    this.ConnectionValue != null &&
                    this.ConnectionValue.Equals(other.ConnectionValue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ConnectionKey != null)
                    hash = hash * 59 + this.ConnectionKey.GetHashCode();
                if (this.ConnectionValue != null)
                    hash = hash * 59 + this.ConnectionValue.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
