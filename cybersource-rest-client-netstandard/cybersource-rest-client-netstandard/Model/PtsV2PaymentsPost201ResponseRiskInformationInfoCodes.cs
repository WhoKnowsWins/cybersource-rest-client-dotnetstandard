/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsPost201ResponseRiskInformationInfoCodes
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseRiskInformationInfoCodes :  IEquatable<PtsV2PaymentsPost201ResponseRiskInformationInfoCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseRiskInformationInfoCodes" /> class.
        /// </summary>
        /// <param name="Velocity">List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  Returned by Decision Manager service. .</param>
        /// <param name="Address">Indicates a mismatch between the customer’s billing and shipping addresses.  Returned by scoring service. .</param>
        /// <param name="CustomerList">Indicates that customer information is associated with transactions that are either on the negative or the positive list.  Returned by scoring service. .</param>
        /// <param name="IdentityChange">Indicates excessive identity changes. The threshold is variable depending on the identity elements being compared. This field can contain one or more information codes, separated by carets (^).  Returned by scoring service. .</param>
        /// <param name="Internet">Indicates a problem with the customer’s email address, IP address, or billing address.  Returned by scoring service. .</param>
        /// <param name="Phone">Indicates a problem with the customer’s phone number.  Returned by scoring service. .</param>
        /// <param name="Suspicious">Indicates that the customer provided potentially suspicious information.  Returned by scoring service. .</param>
        /// <param name="GlobalVelocity">Indicates that the customer has a high purchase frequency.  Returned by scoring service. .</param>
        public PtsV2PaymentsPost201ResponseRiskInformationInfoCodes(List<string> Velocity = default(List<string>), List<string> Address = default(List<string>), List<string> CustomerList = default(List<string>), List<string> IdentityChange = default(List<string>), List<string> Internet = default(List<string>), List<string> Phone = default(List<string>), List<string> Suspicious = default(List<string>), List<string> GlobalVelocity = default(List<string>))
        {
            this.Velocity = Velocity;
            this.Address = Address;
            this.CustomerList = CustomerList;
            this.IdentityChange = IdentityChange;
            this.Internet = Internet;
            this.Phone = Phone;
            this.Suspicious = Suspicious;
            this.GlobalVelocity = GlobalVelocity;
        }
        
        /// <summary>
        /// List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  Returned by Decision Manager service. 
        /// </summary>
        /// <value>List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  Returned by Decision Manager service. </value>
        [DataMember(Name="velocity", EmitDefaultValue=false)]
        public List<string> Velocity { get; set; }

        /// <summary>
        /// Indicates a mismatch between the customer’s billing and shipping addresses.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates a mismatch between the customer’s billing and shipping addresses.  Returned by scoring service. </value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<string> Address { get; set; }

        /// <summary>
        /// Indicates that customer information is associated with transactions that are either on the negative or the positive list.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates that customer information is associated with transactions that are either on the negative or the positive list.  Returned by scoring service. </value>
        [DataMember(Name="customerList", EmitDefaultValue=false)]
        public List<string> CustomerList { get; set; }

        /// <summary>
        /// Indicates excessive identity changes. The threshold is variable depending on the identity elements being compared. This field can contain one or more information codes, separated by carets (^).  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates excessive identity changes. The threshold is variable depending on the identity elements being compared. This field can contain one or more information codes, separated by carets (^).  Returned by scoring service. </value>
        [DataMember(Name="identityChange", EmitDefaultValue=false)]
        public List<string> IdentityChange { get; set; }

        /// <summary>
        /// Indicates a problem with the customer’s email address, IP address, or billing address.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates a problem with the customer’s email address, IP address, or billing address.  Returned by scoring service. </value>
        [DataMember(Name="internet", EmitDefaultValue=false)]
        public List<string> Internet { get; set; }

        /// <summary>
        /// Indicates a problem with the customer’s phone number.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates a problem with the customer’s phone number.  Returned by scoring service. </value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public List<string> Phone { get; set; }

        /// <summary>
        /// Indicates that the customer provided potentially suspicious information.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates that the customer provided potentially suspicious information.  Returned by scoring service. </value>
        [DataMember(Name="suspicious", EmitDefaultValue=false)]
        public List<string> Suspicious { get; set; }

        /// <summary>
        /// Indicates that the customer has a high purchase frequency.  Returned by scoring service. 
        /// </summary>
        /// <value>Indicates that the customer has a high purchase frequency.  Returned by scoring service. </value>
        [DataMember(Name="globalVelocity", EmitDefaultValue=false)]
        public List<string> GlobalVelocity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseRiskInformationInfoCodes {\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CustomerList: ").Append(CustomerList).Append("\n");
            sb.Append("  IdentityChange: ").Append(IdentityChange).Append("\n");
            sb.Append("  Internet: ").Append(Internet).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Suspicious: ").Append(Suspicious).Append("\n");
            sb.Append("  GlobalVelocity: ").Append(GlobalVelocity).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseRiskInformationInfoCodes);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseRiskInformationInfoCodes instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseRiskInformationInfoCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseRiskInformationInfoCodes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Velocity == other.Velocity ||
                    this.Velocity != null &&
                    this.Velocity.SequenceEqual(other.Velocity)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.SequenceEqual(other.Address)
                ) && 
                (
                    this.CustomerList == other.CustomerList ||
                    this.CustomerList != null &&
                    this.CustomerList.SequenceEqual(other.CustomerList)
                ) && 
                (
                    this.IdentityChange == other.IdentityChange ||
                    this.IdentityChange != null &&
                    this.IdentityChange.SequenceEqual(other.IdentityChange)
                ) && 
                (
                    this.Internet == other.Internet ||
                    this.Internet != null &&
                    this.Internet.SequenceEqual(other.Internet)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.SequenceEqual(other.Phone)
                ) && 
                (
                    this.Suspicious == other.Suspicious ||
                    this.Suspicious != null &&
                    this.Suspicious.SequenceEqual(other.Suspicious)
                ) && 
                (
                    this.GlobalVelocity == other.GlobalVelocity ||
                    this.GlobalVelocity != null &&
                    this.GlobalVelocity.SequenceEqual(other.GlobalVelocity)
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
                if (this.Velocity != null)
                    hash = hash * 59 + this.Velocity.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.CustomerList != null)
                    hash = hash * 59 + this.CustomerList.GetHashCode();
                if (this.IdentityChange != null)
                    hash = hash * 59 + this.IdentityChange.GetHashCode();
                if (this.Internet != null)
                    hash = hash * 59 + this.Internet.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Suspicious != null)
                    hash = hash * 59 + this.Suspicious.GetHashCode();
                if (this.GlobalVelocity != null)
                    hash = hash * 59 + this.GlobalVelocity.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}