/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// AdminMessage
    /// </summary>
    [DataContract]
    public partial class AdminMessage :  IEquatable<AdminMessage>, IValidatableObject
    {
        public AdminMessage()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMessage" /> class.
        /// </summary>
        /// <param name="BaseMessage">BaseMessage.</param>
        /// <param name="MoreInformation">MoreInformation.</param>
        public AdminMessage(string BaseMessage = default(string), string MoreInformation = default(string))
        {
            this.BaseMessage = BaseMessage;
            this.MoreInformation = MoreInformation;
        }
        
        /// <summary>
        /// Gets or Sets BaseMessage
        /// </summary>
        [DataMember(Name="baseMessage", EmitDefaultValue=false)]
        public string BaseMessage { get; set; }
        /// <summary>
        /// Gets or Sets MoreInformation
        /// </summary>
        [DataMember(Name="moreInformation", EmitDefaultValue=false)]
        public string MoreInformation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminMessage {\n");
            sb.Append("  BaseMessage: ").Append(BaseMessage).Append("\n");
            sb.Append("  MoreInformation: ").Append(MoreInformation).Append("\n");
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
            return this.Equals(obj as AdminMessage);
        }

        /// <summary>
        /// Returns true if AdminMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BaseMessage == other.BaseMessage ||
                    this.BaseMessage != null &&
                    this.BaseMessage.Equals(other.BaseMessage)
                ) && 
                (
                    this.MoreInformation == other.MoreInformation ||
                    this.MoreInformation != null &&
                    this.MoreInformation.Equals(other.MoreInformation)
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
                if (this.BaseMessage != null)
                    hash = hash * 59 + this.BaseMessage.GetHashCode();
                if (this.MoreInformation != null)
                    hash = hash * 59 + this.MoreInformation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}