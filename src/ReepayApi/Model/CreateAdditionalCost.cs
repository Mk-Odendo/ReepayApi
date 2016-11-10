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
    /// CreateAdditionalCost
    /// </summary>
    [DataContract]
    public partial class CreateAdditionalCost :  IEquatable<CreateAdditionalCost>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdditionalCost" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateAdditionalCost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdditionalCost" /> class.
        /// </summary>
        /// <param name="Ordertext">Order text for the additional cost. Will be on affected invoices. (required).</param>
        /// <param name="Quantity">Quantity for the additional cost. Default 1..</param>
        /// <param name="Amount">Per quantity amount in the smallest unit for the account currency (required).</param>
        /// <param name="Vat">Optional vat for additional cost. Account default is used if none given..</param>
        /// <param name="AmountInclVat">Whether the per quantity amount is including VAT. Defaults to true. (default to false).</param>
        public CreateAdditionalCost(string Ordertext = null, int? Quantity = null, int? Amount = null, float? Vat = null, bool? AmountInclVat = null)
        {
            // to ensure "Ordertext" is required (not null)
            if (Ordertext == null)
            {
                throw new InvalidDataException("Ordertext is a required property for CreateAdditionalCost and cannot be null");
            }
            else
            {
                this.Ordertext = Ordertext;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for CreateAdditionalCost and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            this.Quantity = Quantity;
            this.Vat = Vat;
            // use default value if no "AmountInclVat" provided
            if (AmountInclVat == null)
            {
                this.AmountInclVat = false;
            }
            else
            {
                this.AmountInclVat = AmountInclVat;
            }
        }
        
        /// <summary>
        /// Subscription handle
        /// </summary>
        /// <value>Subscription handle</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; private set; }
        /// <summary>
        /// Per account unique handle for the additional cost
        /// </summary>
        /// <value>Per account unique handle for the additional cost</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; private set; }
        /// <summary>
        /// Order text for the additional cost. Will be on affected invoices.
        /// </summary>
        /// <value>Order text for the additional cost. Will be on affected invoices.</value>
        [DataMember(Name="ordertext", EmitDefaultValue=false)]
        public string Ordertext { get; set; }
        /// <summary>
        /// Quantity for the additional cost. Default 1.
        /// </summary>
        /// <value>Quantity for the additional cost. Default 1.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
        /// <summary>
        /// Per quantity amount in the smallest unit for the account currency
        /// </summary>
        /// <value>Per quantity amount in the smallest unit for the account currency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
        /// <summary>
        /// Optional vat for additional cost. Account default is used if none given.
        /// </summary>
        /// <value>Optional vat for additional cost. Account default is used if none given.</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public float? Vat { get; set; }
        /// <summary>
        /// Whether the per quantity amount is including VAT. Defaults to true.
        /// </summary>
        /// <value>Whether the per quantity amount is including VAT. Defaults to true.</value>
        [DataMember(Name="amount_incl_vat", EmitDefaultValue=false)]
        public bool? AmountInclVat { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAdditionalCost {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Ordertext: ").Append(Ordertext).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  AmountInclVat: ").Append(AmountInclVat).Append("\n");
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
            return this.Equals(obj as CreateAdditionalCost);
        }

        /// <summary>
        /// Returns true if CreateAdditionalCost instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateAdditionalCost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAdditionalCost other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
                ) && 
                (
                    this.Ordertext == other.Ordertext ||
                    this.Ordertext != null &&
                    this.Ordertext.Equals(other.Ordertext)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Vat == other.Vat ||
                    this.Vat != null &&
                    this.Vat.Equals(other.Vat)
                ) && 
                (
                    this.AmountInclVat == other.AmountInclVat ||
                    this.AmountInclVat != null &&
                    this.AmountInclVat.Equals(other.AmountInclVat)
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
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();
                if (this.Ordertext != null)
                    hash = hash * 59 + this.Ordertext.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Vat != null)
                    hash = hash * 59 + this.Vat.GetHashCode();
                if (this.AmountInclVat != null)
                    hash = hash * 59 + this.AmountInclVat.GetHashCode();
                return hash;
            }
        }
    }

}
