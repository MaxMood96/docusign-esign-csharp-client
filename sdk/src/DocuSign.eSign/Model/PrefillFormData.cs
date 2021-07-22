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
    /// PrefillFormData
    /// </summary>
    [DataContract]
    public partial class PrefillFormData :  IEquatable<PrefillFormData>, IValidatableObject
    {
        public PrefillFormData()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefillFormData" /> class.
        /// </summary>
        /// <param name="FormData">FormData.</param>
        /// <param name="SenderEmail">SenderEmail.</param>
        /// <param name="SenderName">SenderName.</param>
        /// <param name="SenderUserId">SenderUserId.</param>
        public PrefillFormData(List<FormDataItem> FormData = default(List<FormDataItem>), string SenderEmail = default(string), string SenderName = default(string), string SenderUserId = default(string))
        {
            this.FormData = FormData;
            this.SenderEmail = SenderEmail;
            this.SenderName = SenderName;
            this.SenderUserId = SenderUserId;
        }
        
        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public List<FormDataItem> FormData { get; set; }
        /// <summary>
        /// Gets or Sets SenderEmail
        /// </summary>
        [DataMember(Name="senderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }
        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }
        /// <summary>
        /// Gets or Sets SenderUserId
        /// </summary>
        [DataMember(Name="senderUserId", EmitDefaultValue=false)]
        public string SenderUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrefillFormData {\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
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
            return this.Equals(obj as PrefillFormData);
        }

        /// <summary>
        /// Returns true if PrefillFormData instances are equal
        /// </summary>
        /// <param name="other">Instance of PrefillFormData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrefillFormData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormData == other.FormData ||
                    this.FormData != null &&
                    this.FormData.SequenceEqual(other.FormData)
                ) && 
                (
                    this.SenderEmail == other.SenderEmail ||
                    this.SenderEmail != null &&
                    this.SenderEmail.Equals(other.SenderEmail)
                ) && 
                (
                    this.SenderName == other.SenderName ||
                    this.SenderName != null &&
                    this.SenderName.Equals(other.SenderName)
                ) && 
                (
                    this.SenderUserId == other.SenderUserId ||
                    this.SenderUserId != null &&
                    this.SenderUserId.Equals(other.SenderUserId)
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
                if (this.FormData != null)
                    hash = hash * 59 + this.FormData.GetHashCode();
                if (this.SenderEmail != null)
                    hash = hash * 59 + this.SenderEmail.GetHashCode();
                if (this.SenderName != null)
                    hash = hash * 59 + this.SenderName.GetHashCode();
                if (this.SenderUserId != null)
                    hash = hash * 59 + this.SenderUserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}