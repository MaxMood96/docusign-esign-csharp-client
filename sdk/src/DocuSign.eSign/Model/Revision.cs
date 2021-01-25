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
    /// Revision
    /// </summary>
    [DataContract]
    public partial class Revision :  IEquatable<Revision>, IValidatableObject
    {
        public Revision()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Revision" /> class.
        /// </summary>
        /// <param name="EndData">EndData.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="MaxSignatureLength">MaxSignatureLength.</param>
        /// <param name="SignatureProperties">SignatureProperties.</param>
        /// <param name="SignatureType">SignatureType.</param>
        /// <param name="StartData">StartData.</param>
        public Revision(string EndData = default(string), string FieldName = default(string), string MaxSignatureLength = default(string), SignatureProperties SignatureProperties = default(SignatureProperties), string SignatureType = default(string), string StartData = default(string))
        {
            this.EndData = EndData;
            this.FieldName = FieldName;
            this.MaxSignatureLength = MaxSignatureLength;
            this.SignatureProperties = SignatureProperties;
            this.SignatureType = SignatureType;
            this.StartData = StartData;
        }
        
        /// <summary>
        /// Gets or Sets EndData
        /// </summary>
        [DataMember(Name="endData", EmitDefaultValue=false)]
        public string EndData { get; set; }
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
        /// <summary>
        /// Gets or Sets MaxSignatureLength
        /// </summary>
        [DataMember(Name="maxSignatureLength", EmitDefaultValue=false)]
        public string MaxSignatureLength { get; set; }
        /// <summary>
        /// Gets or Sets SignatureProperties
        /// </summary>
        [DataMember(Name="signatureProperties", EmitDefaultValue=false)]
        public SignatureProperties SignatureProperties { get; set; }
        /// <summary>
        /// Gets or Sets SignatureType
        /// </summary>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }
        /// <summary>
        /// Gets or Sets StartData
        /// </summary>
        [DataMember(Name="startData", EmitDefaultValue=false)]
        public string StartData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Revision {\n");
            sb.Append("  EndData: ").Append(EndData).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  MaxSignatureLength: ").Append(MaxSignatureLength).Append("\n");
            sb.Append("  SignatureProperties: ").Append(SignatureProperties).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  StartData: ").Append(StartData).Append("\n");
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
            return this.Equals(obj as Revision);
        }

        /// <summary>
        /// Returns true if Revision instances are equal
        /// </summary>
        /// <param name="other">Instance of Revision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Revision other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndData == other.EndData ||
                    this.EndData != null &&
                    this.EndData.Equals(other.EndData)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.MaxSignatureLength == other.MaxSignatureLength ||
                    this.MaxSignatureLength != null &&
                    this.MaxSignatureLength.Equals(other.MaxSignatureLength)
                ) && 
                (
                    this.SignatureProperties == other.SignatureProperties ||
                    this.SignatureProperties != null &&
                    this.SignatureProperties.Equals(other.SignatureProperties)
                ) && 
                (
                    this.SignatureType == other.SignatureType ||
                    this.SignatureType != null &&
                    this.SignatureType.Equals(other.SignatureType)
                ) && 
                (
                    this.StartData == other.StartData ||
                    this.StartData != null &&
                    this.StartData.Equals(other.StartData)
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
                if (this.EndData != null)
                    hash = hash * 59 + this.EndData.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.MaxSignatureLength != null)
                    hash = hash * 59 + this.MaxSignatureLength.GetHashCode();
                if (this.SignatureProperties != null)
                    hash = hash * 59 + this.SignatureProperties.GetHashCode();
                if (this.SignatureType != null)
                    hash = hash * 59 + this.SignatureType.GetHashCode();
                if (this.StartData != null)
                    hash = hash * 59 + this.StartData.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
