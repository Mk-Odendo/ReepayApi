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
    /// AdditionalCost
    /// </summary>
    [DataContract]
    public partial class AdditionalCost :  IEquatable<AdditionalCost>
    {
        /// <summary>
        /// State of the additional cost, one of the following: `pending`, `transferred`, `cancelled`. A pending additonal cost has not yet been transferred to a invoice. Cancelled addtional costs have been cancelled manually.
        /// </summary>
        /// <value>State of the additional cost, one of the following: `pending`, `transferred`, `cancelled`. A pending additonal cost has not yet been transferred to a invoice. Cancelled addtional costs have been cancelled manually.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Transferred for "transferred"
            /// </summary>
            [EnumMember(Value = "transferred")]
            Transferred,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled
        }

        /// <summary>
        /// State of the additional cost, one of the following: `pending`, `transferred`, `cancelled`. A pending additonal cost has not yet been transferred to a invoice. Cancelled addtional costs have been cancelled manually.
        /// </summary>
        /// <value>State of the additional cost, one of the following: `pending`, `transferred`, `cancelled`. A pending additonal cost has not yet been transferred to a invoice. Cancelled addtional costs have been cancelled manually.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalCost" /> class.
        /// </summary>
        [JsonConstructor]
        protected AdditionalCost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalCost" /> class.
        /// </summary>
        /// <param name="Ordertext">Order text for the additional cost. Will be on affected invoices. (required).</param>
        /// <param name="Quantity">Quantity for the additional cost. Default 1..</param>
        /// <param name="Amount">Additional cost total amount (required).</param>
        /// <param name="Vat">Optional vat for additional cost. Account default is used if none given..</param>
        /// <param name="AmountInclVat">Whether the amount is including VAT. Default true. (required) (default to false).</param>
        public AdditionalCost(string Ordertext = null, int? Quantity = null, int? Amount = null, float? Vat = null, bool? AmountInclVat = null)
        {
            // to ensure "Ordertext" is required (not null)
            if (Ordertext == null)
            {
                throw new InvalidDataException("Ordertext is a required property for AdditionalCost and cannot be null");
            }
            else
            {
                this.Ordertext = Ordertext;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for AdditionalCost and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
            // to ensure "AmountInclVat" is required (not null)
            if (AmountInclVat == null)
            {
                throw new InvalidDataException("AmountInclVat is a required property for AdditionalCost and cannot be null");
            }
            else
            {
                this.AmountInclVat = AmountInclVat;
            }
            this.Quantity = Quantity;
            this.Vat = Vat;
        }
        
        /// <summary>
        /// Invoice id for the invoice the additional cost has been assigned to
        /// </summary>
        /// <value>Invoice id for the invoice the additional cost has been assigned to</value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public string Invoice { get; private set; }
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
        /// Additional cost total amount
        /// </summary>
        /// <value>Additional cost total amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }
        /// <summary>
        /// Optional vat for additional cost. Account default is used if none given.
        /// </summary>
        /// <value>Optional vat for additional cost. Account default is used if none given.</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public float? Vat { get; set; }
        /// <summary>
        /// Date when the additional cost was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>Date when the additional cost was created. In [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; private set; }
        /// <summary>
        /// Whether the amount is including VAT. Default true.
        /// </summary>
        /// <value>Whether the amount is including VAT. Default true.</value>
        [DataMember(Name="amount_incl_vat", EmitDefaultValue=false)]
        public bool? AmountInclVat { get; set; }
        /// <summary>
        /// Additional cost vat amount
        /// </summary>
        /// <value>Additional cost vat amount</value>
        [DataMember(Name="amount_vat", EmitDefaultValue=false)]
        public int? AmountVat { get; private set; }
        /// <summary>
        /// Additional cost amount without vat
        /// </summary>
        /// <value>Additional cost amount without vat</value>
        [DataMember(Name="amount_ex_vat", EmitDefaultValue=false)]
        public int? AmountExVat { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalCost {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Ordertext: ").Append(Ordertext).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AmountInclVat: ").Append(AmountInclVat).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountExVat: ").Append(AmountExVat).Append("\n");
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
            return this.Equals(obj as AdditionalCost);
        }

        /// <summary>
        /// Returns true if AdditionalCost instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalCost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalCost other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
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
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.AmountInclVat == other.AmountInclVat ||
                    this.AmountInclVat != null &&
                    this.AmountInclVat.Equals(other.AmountInclVat)
                ) && 
                (
                    this.AmountVat == other.AmountVat ||
                    this.AmountVat != null &&
                    this.AmountVat.Equals(other.AmountVat)
                ) && 
                (
                    this.AmountExVat == other.AmountExVat ||
                    this.AmountExVat != null &&
                    this.AmountExVat.Equals(other.AmountExVat)
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
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.AmountInclVat != null)
                    hash = hash * 59 + this.AmountInclVat.GetHashCode();
                if (this.AmountVat != null)
                    hash = hash * 59 + this.AmountVat.GetHashCode();
                if (this.AmountExVat != null)
                    hash = hash * 59 + this.AmountExVat.GetHashCode();
                return hash;
            }
        }
    }

}
