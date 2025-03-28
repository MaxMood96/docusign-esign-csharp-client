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
    /// LinkedExternalPrimaryAccount
    /// </summary>
    [DataContract]
    public partial class LinkedExternalPrimaryAccount :  IEquatable<LinkedExternalPrimaryAccount>, IValidatableObject
    {
        public LinkedExternalPrimaryAccount()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedExternalPrimaryAccount" /> class.
        /// </summary>
        /// <param name="AccountName">AccountName.</param>
        /// <param name="ConfigurationId">ConfigurationId.</param>
        /// <param name="Email">Email.</param>
        /// <param name="ExemptMembersOfSameAccountFromAuth">ExemptMembersOfSameAccountFromAuth.</param>
        /// <param name="LinkId">LinkId.</param>
        /// <param name="PdfFieldHandlingOption">PdfFieldHandlingOption.</param>
        /// <param name="PdfFieldHandlingPrefillTabPermission">PdfFieldHandlingPrefillTabPermission.</param>
        /// <param name="PdfFieldHandlingStandardInputTabPermission">PdfFieldHandlingStandardInputTabPermission.</param>
        /// <param name="PdfFieldHandlingStandardTabPermission">PdfFieldHandlingStandardTabPermission.</param>
        /// <param name="RecipientAuthRequirements">RecipientAuthRequirements.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="UserId">UserId.</param>
        public LinkedExternalPrimaryAccount(string AccountName = default(string), string ConfigurationId = default(string), string Email = default(string), string ExemptMembersOfSameAccountFromAuth = default(string), string LinkId = default(string), string PdfFieldHandlingOption = default(string), string PdfFieldHandlingPrefillTabPermission = default(string), string PdfFieldHandlingStandardInputTabPermission = default(string), string PdfFieldHandlingStandardTabPermission = default(string), ExternalPrimaryAccountRecipientAuthRequirements RecipientAuthRequirements = default(ExternalPrimaryAccountRecipientAuthRequirements), string Status = default(string), string UserId = default(string))
        {
            this.AccountName = AccountName;
            this.ConfigurationId = ConfigurationId;
            this.Email = Email;
            this.ExemptMembersOfSameAccountFromAuth = ExemptMembersOfSameAccountFromAuth;
            this.LinkId = LinkId;
            this.PdfFieldHandlingOption = PdfFieldHandlingOption;
            this.PdfFieldHandlingPrefillTabPermission = PdfFieldHandlingPrefillTabPermission;
            this.PdfFieldHandlingStandardInputTabPermission = PdfFieldHandlingStandardInputTabPermission;
            this.PdfFieldHandlingStandardTabPermission = PdfFieldHandlingStandardTabPermission;
            this.RecipientAuthRequirements = RecipientAuthRequirements;
            this.Status = Status;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets ConfigurationId
        /// </summary>
        [DataMember(Name="configurationId", EmitDefaultValue=false)]
        public string ConfigurationId { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets ExemptMembersOfSameAccountFromAuth
        /// </summary>
        [DataMember(Name="exemptMembersOfSameAccountFromAuth", EmitDefaultValue=false)]
        public string ExemptMembersOfSameAccountFromAuth { get; set; }
        /// <summary>
        /// Gets or Sets LinkId
        /// </summary>
        [DataMember(Name="linkId", EmitDefaultValue=false)]
        public string LinkId { get; set; }
        /// <summary>
        /// Gets or Sets PdfFieldHandlingOption
        /// </summary>
        [DataMember(Name="pdfFieldHandlingOption", EmitDefaultValue=false)]
        public string PdfFieldHandlingOption { get; set; }
        /// <summary>
        /// Gets or Sets PdfFieldHandlingPrefillTabPermission
        /// </summary>
        [DataMember(Name="pdfFieldHandlingPrefillTabPermission", EmitDefaultValue=false)]
        public string PdfFieldHandlingPrefillTabPermission { get; set; }
        /// <summary>
        /// Gets or Sets PdfFieldHandlingStandardInputTabPermission
        /// </summary>
        [DataMember(Name="pdfFieldHandlingStandardInputTabPermission", EmitDefaultValue=false)]
        public string PdfFieldHandlingStandardInputTabPermission { get; set; }
        /// <summary>
        /// Gets or Sets PdfFieldHandlingStandardTabPermission
        /// </summary>
        [DataMember(Name="pdfFieldHandlingStandardTabPermission", EmitDefaultValue=false)]
        public string PdfFieldHandlingStandardTabPermission { get; set; }
        /// <summary>
        /// Gets or Sets RecipientAuthRequirements
        /// </summary>
        [DataMember(Name="recipientAuthRequirements", EmitDefaultValue=false)]
        public ExternalPrimaryAccountRecipientAuthRequirements RecipientAuthRequirements { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedExternalPrimaryAccount {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ConfigurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExemptMembersOfSameAccountFromAuth: ").Append(ExemptMembersOfSameAccountFromAuth).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  PdfFieldHandlingOption: ").Append(PdfFieldHandlingOption).Append("\n");
            sb.Append("  PdfFieldHandlingPrefillTabPermission: ").Append(PdfFieldHandlingPrefillTabPermission).Append("\n");
            sb.Append("  PdfFieldHandlingStandardInputTabPermission: ").Append(PdfFieldHandlingStandardInputTabPermission).Append("\n");
            sb.Append("  PdfFieldHandlingStandardTabPermission: ").Append(PdfFieldHandlingStandardTabPermission).Append("\n");
            sb.Append("  RecipientAuthRequirements: ").Append(RecipientAuthRequirements).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as LinkedExternalPrimaryAccount);
        }

        /// <summary>
        /// Returns true if LinkedExternalPrimaryAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkedExternalPrimaryAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedExternalPrimaryAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) && 
                (
                    this.ConfigurationId == other.ConfigurationId ||
                    this.ConfigurationId != null &&
                    this.ConfigurationId.Equals(other.ConfigurationId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ExemptMembersOfSameAccountFromAuth == other.ExemptMembersOfSameAccountFromAuth ||
                    this.ExemptMembersOfSameAccountFromAuth != null &&
                    this.ExemptMembersOfSameAccountFromAuth.Equals(other.ExemptMembersOfSameAccountFromAuth)
                ) && 
                (
                    this.LinkId == other.LinkId ||
                    this.LinkId != null &&
                    this.LinkId.Equals(other.LinkId)
                ) && 
                (
                    this.PdfFieldHandlingOption == other.PdfFieldHandlingOption ||
                    this.PdfFieldHandlingOption != null &&
                    this.PdfFieldHandlingOption.Equals(other.PdfFieldHandlingOption)
                ) && 
                (
                    this.PdfFieldHandlingPrefillTabPermission == other.PdfFieldHandlingPrefillTabPermission ||
                    this.PdfFieldHandlingPrefillTabPermission != null &&
                    this.PdfFieldHandlingPrefillTabPermission.Equals(other.PdfFieldHandlingPrefillTabPermission)
                ) && 
                (
                    this.PdfFieldHandlingStandardInputTabPermission == other.PdfFieldHandlingStandardInputTabPermission ||
                    this.PdfFieldHandlingStandardInputTabPermission != null &&
                    this.PdfFieldHandlingStandardInputTabPermission.Equals(other.PdfFieldHandlingStandardInputTabPermission)
                ) && 
                (
                    this.PdfFieldHandlingStandardTabPermission == other.PdfFieldHandlingStandardTabPermission ||
                    this.PdfFieldHandlingStandardTabPermission != null &&
                    this.PdfFieldHandlingStandardTabPermission.Equals(other.PdfFieldHandlingStandardTabPermission)
                ) && 
                (
                    this.RecipientAuthRequirements == other.RecipientAuthRequirements ||
                    this.RecipientAuthRequirements != null &&
                    this.RecipientAuthRequirements.Equals(other.RecipientAuthRequirements)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ConfigurationId != null)
                    hash = hash * 59 + this.ConfigurationId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ExemptMembersOfSameAccountFromAuth != null)
                    hash = hash * 59 + this.ExemptMembersOfSameAccountFromAuth.GetHashCode();
                if (this.LinkId != null)
                    hash = hash * 59 + this.LinkId.GetHashCode();
                if (this.PdfFieldHandlingOption != null)
                    hash = hash * 59 + this.PdfFieldHandlingOption.GetHashCode();
                if (this.PdfFieldHandlingPrefillTabPermission != null)
                    hash = hash * 59 + this.PdfFieldHandlingPrefillTabPermission.GetHashCode();
                if (this.PdfFieldHandlingStandardInputTabPermission != null)
                    hash = hash * 59 + this.PdfFieldHandlingStandardInputTabPermission.GetHashCode();
                if (this.PdfFieldHandlingStandardTabPermission != null)
                    hash = hash * 59 + this.PdfFieldHandlingStandardTabPermission.GetHashCode();
                if (this.RecipientAuthRequirements != null)
                    hash = hash * 59 + this.RecipientAuthRequirements.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
