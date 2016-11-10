/* 
 * Reepay API
 *
 * REST API to manage Reepay resources
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ReepayApi.Model
{
    /// <summary>
    /// CreateSubscriptionDiscount
    /// </summary>
    [DataContract]
    public partial class CreateSubscriptionDiscount :  IEquatable<CreateSubscriptionDiscount>
    {
        /// <summary>
        /// Optioanl overriding discount settings
        /// </summary>
        /// <value>Optioanl overriding discount settings</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FixedPeriodUnitEnum
        {
            
            /// <summary>
            /// Enum Months for "months"
            /// </summary>
            [EnumMember(Value = "months")]
            Months,
            
            /// <summary>
            /// Enum Days for "days"
            /// </summary>
            [EnumMember(Value = "days")]
            Days
        }

        /// <summary>
        /// Optioanl overriding discount settings
        /// </summary>
        /// <value>Optioanl overriding discount settings</value>
        [DataMember(Name="fixed_period_unit", EmitDefaultValue=false)]
        public FixedPeriodUnitEnum? FixedPeriodUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionDiscount" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateSubscriptionDiscount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionDiscount" /> class.
        /// </summary>
        /// <param name="Handle">Per subscription unique handle for the subscription discount. (required).</param>
        /// <param name="Discount">Discount for subscription discount (required).</param>
        /// <param name="Name">Optional name overrding discount name.</param>
        /// <param name="Description">Optional description overriding discount description.</param>
        /// <param name="Amount">Optional overriding fixed amount from discount.</param>
        /// <param name="Percentage">Optional percentage overriding percentage from discount.</param>
        /// <param name="ApplyTo">Optional overriding discount settings.</param>
        /// <param name="FixedCount">Optioanl overriding discount settings.</param>
        /// <param name="FixedPeriodUnit">Optioanl overriding discount settings.</param>
        /// <param name="FixedPeriod">Optioanl overriding discount settings.</param>
        public CreateSubscriptionDiscount(string Handle = null, string Discount = null, string Name = null, string Description = null, int? Amount = null, int? Percentage = null, List<string> ApplyTo = null, int? FixedCount = null, FixedPeriodUnitEnum? FixedPeriodUnit = null, int? FixedPeriod = null)
        {
            // to ensure "Handle" is required (not null)
            if (Handle == null)
            {
                throw new InvalidDataException("Handle is a required property for CreateSubscriptionDiscount and cannot be null");
            }
            else
            {
                this.Handle = Handle;
            }
            // to ensure "Discount" is required (not null)
            if (Discount == null)
            {
                throw new InvalidDataException("Discount is a required property for CreateSubscriptionDiscount and cannot be null");
            }
            else
            {
                this.Discount = Discount;
            }
            this.Name = Name;
            this.Description = Description;
            this.Amount = Amount;
            this.Percentage = Percentage;
            this.ApplyTo = ApplyTo;
            this.FixedCount = FixedCount;
            this.FixedPeriodUnit = FixedPeriodUnit;
            this.FixedPeriod = FixedPeriod;
        }
        
        /// <summary>
        /// Per subscription unique handle for the subscription discount.
        /// </summary>
        /// <value>Per subscription unique handle for the subscription discount.</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; set; }
        /// <summary>
        /// Discount for subscription discount
        /// </summary>
        /// <value>Discount for subscription discount</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public string Discount { get; set; }
        /// <summary>
        /// Optional name overrding discount name
        /// </summary>
        /// <value>Optional name overrding discount name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Optional description overriding discount description
        /// </summary>
        /// <value>Optional description overriding discount description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Optional overriding fixed amount from discount
        /// </summary>
        /// <value>Optional overriding fixed amount from discount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
        /// <summary>
        /// Optional percentage overriding percentage from discount
        /// </summary>
        /// <value>Optional percentage overriding percentage from discount</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }
        /// <summary>
        /// Optional overriding discount settings
        /// </summary>
        /// <value>Optional overriding discount settings</value>
        [DataMember(Name="apply_to", EmitDefaultValue=false)]
        public List<string> ApplyTo { get; set; }
        /// <summary>
        /// Optioanl overriding discount settings
        /// </summary>
        /// <value>Optioanl overriding discount settings</value>
        [DataMember(Name="fixed_count", EmitDefaultValue=false)]
        public int? FixedCount { get; set; }
        /// <summary>
        /// Optioanl overriding discount settings
        /// </summary>
        /// <value>Optioanl overriding discount settings</value>
        [DataMember(Name="fixed_period", EmitDefaultValue=false)]
        public int? FixedPeriod { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionDiscount {\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  ApplyTo: ").Append(ApplyTo).Append("\n");
            sb.Append("  FixedCount: ").Append(FixedCount).Append("\n");
            sb.Append("  FixedPeriodUnit: ").Append(FixedPeriodUnit).Append("\n");
            sb.Append("  FixedPeriod: ").Append(FixedPeriod).Append("\n");
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
            return this.Equals(obj as CreateSubscriptionDiscount);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSubscriptionDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.ApplyTo == other.ApplyTo ||
                    this.ApplyTo != null &&
                    this.ApplyTo.SequenceEqual(other.ApplyTo)
                ) && 
                (
                    this.FixedCount == other.FixedCount ||
                    this.FixedCount != null &&
                    this.FixedCount.Equals(other.FixedCount)
                ) && 
                (
                    this.FixedPeriodUnit == other.FixedPeriodUnit ||
                    this.FixedPeriodUnit != null &&
                    this.FixedPeriodUnit.Equals(other.FixedPeriodUnit)
                ) && 
                (
                    this.FixedPeriod == other.FixedPeriod ||
                    this.FixedPeriod != null &&
                    this.FixedPeriod.Equals(other.FixedPeriod)
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
                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.ApplyTo != null)
                    hash = hash * 59 + this.ApplyTo.GetHashCode();
                if (this.FixedCount != null)
                    hash = hash * 59 + this.FixedCount.GetHashCode();
                if (this.FixedPeriodUnit != null)
                    hash = hash * 59 + this.FixedPeriodUnit.GetHashCode();
                if (this.FixedPeriod != null)
                    hash = hash * 59 + this.FixedPeriod.GetHashCode();
                return hash;
            }
        }
    }

}
