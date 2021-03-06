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
    /// CreateSubscriptionInvoice
    /// </summary>
    [DataContract]
    public partial class CreateSubscriptionInvoice :  IEquatable<CreateSubscriptionInvoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionInvoice" /> class.
        /// </summary>
        /// <param name="_Ref">Optional reference to avoid double creations. Only one invoice can be created per reference..</param>
        /// <param name="Instant">Create and process transaction instantly and only create invoice for successful transaction (default false) (default to false).</param>
        /// <param name="Due">Optional due date and time on the form yyyy-MM-dd, yyyyMMdd, yyyy-MM-ddTHH:mm and yyyy-MM-ddTHH:mm:ss from which the invoice is eligible to be collected.</param>
        /// <param name="PlanManual">Create manually for plan by adding plan product as orderline (default false) (default to false).</param>
        /// <param name="CollectAdditionalCosts">Collect pending additional costs and transfer to invoice (default true) (default to false).</param>
        /// <param name="CollectCredit">Collect pending credit and transfer to invoice (default true) (default to false).</param>
        /// <param name="ApplyDiscounts">Apply potential discounts for the subscription to the invoice order lines (default true) (default to false).</param>
        /// <param name="OrderLines">Optional orderlines for the invoice.</param>
        /// <param name="ManualTransfer">Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction..</param>
        public CreateSubscriptionInvoice(string _Ref = null, bool? Instant = null, string Due = null, bool? PlanManual = null, bool? CollectAdditionalCosts = null, bool? CollectCredit = null, bool? ApplyDiscounts = null, List<CreateOrderLine> OrderLines = null, ManualSettleTransfer ManualTransfer = null)
        {
            this._Ref = _Ref;
            // use default value if no "Instant" provided
            if (Instant == null)
            {
                this.Instant = false;
            }
            else
            {
                this.Instant = Instant;
            }
            this.Due = Due;
            // use default value if no "PlanManual" provided
            if (PlanManual == null)
            {
                this.PlanManual = false;
            }
            else
            {
                this.PlanManual = PlanManual;
            }
            // use default value if no "CollectAdditionalCosts" provided
            if (CollectAdditionalCosts == null)
            {
                this.CollectAdditionalCosts = false;
            }
            else
            {
                this.CollectAdditionalCosts = CollectAdditionalCosts;
            }
            // use default value if no "CollectCredit" provided
            if (CollectCredit == null)
            {
                this.CollectCredit = false;
            }
            else
            {
                this.CollectCredit = CollectCredit;
            }
            // use default value if no "ApplyDiscounts" provided
            if (ApplyDiscounts == null)
            {
                this.ApplyDiscounts = false;
            }
            else
            {
                this.ApplyDiscounts = ApplyDiscounts;
            }
            this.OrderLines = OrderLines;
            this.ManualTransfer = ManualTransfer;
        }
        
        /// <summary>
        /// Optional reference to avoid double creations. Only one invoice can be created per reference.
        /// </summary>
        /// <value>Optional reference to avoid double creations. Only one invoice can be created per reference.</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string _Ref { get; set; }
        /// <summary>
        /// Create and process transaction instantly and only create invoice for successful transaction (default false)
        /// </summary>
        /// <value>Create and process transaction instantly and only create invoice for successful transaction (default false)</value>
        [DataMember(Name="instant", EmitDefaultValue=false)]
        public bool? Instant { get; set; }
        /// <summary>
        /// Optional due date and time on the form yyyy-MM-dd, yyyyMMdd, yyyy-MM-ddTHH:mm and yyyy-MM-ddTHH:mm:ss from which the invoice is eligible to be collected
        /// </summary>
        /// <value>Optional due date and time on the form yyyy-MM-dd, yyyyMMdd, yyyy-MM-ddTHH:mm and yyyy-MM-ddTHH:mm:ss from which the invoice is eligible to be collected</value>
        [DataMember(Name="due", EmitDefaultValue=false)]
        public string Due { get; set; }
        /// <summary>
        /// Create manually for plan by adding plan product as orderline (default false)
        /// </summary>
        /// <value>Create manually for plan by adding plan product as orderline (default false)</value>
        [DataMember(Name="plan_manual", EmitDefaultValue=false)]
        public bool? PlanManual { get; set; }
        /// <summary>
        /// Collect pending additional costs and transfer to invoice (default true)
        /// </summary>
        /// <value>Collect pending additional costs and transfer to invoice (default true)</value>
        [DataMember(Name="collect_additional_costs", EmitDefaultValue=false)]
        public bool? CollectAdditionalCosts { get; set; }
        /// <summary>
        /// Collect pending credit and transfer to invoice (default true)
        /// </summary>
        /// <value>Collect pending credit and transfer to invoice (default true)</value>
        [DataMember(Name="collect_credit", EmitDefaultValue=false)]
        public bool? CollectCredit { get; set; }
        /// <summary>
        /// Apply potential discounts for the subscription to the invoice order lines (default true)
        /// </summary>
        /// <value>Apply potential discounts for the subscription to the invoice order lines (default true)</value>
        [DataMember(Name="apply_discounts", EmitDefaultValue=false)]
        public bool? ApplyDiscounts { get; set; }
        /// <summary>
        /// Optional orderlines for the invoice
        /// </summary>
        /// <value>Optional orderlines for the invoice</value>
        [DataMember(Name="order_lines", EmitDefaultValue=false)]
        public List<CreateOrderLine> OrderLines { get; set; }
        /// <summary>
        /// Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction.
        /// </summary>
        /// <value>Optional manual tranfer. If given the invoice will be settled using the manual transfer transaction.</value>
        [DataMember(Name="manual_transfer", EmitDefaultValue=false)]
        public ManualSettleTransfer ManualTransfer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionInvoice {\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
            sb.Append("  Instant: ").Append(Instant).Append("\n");
            sb.Append("  Due: ").Append(Due).Append("\n");
            sb.Append("  PlanManual: ").Append(PlanManual).Append("\n");
            sb.Append("  CollectAdditionalCosts: ").Append(CollectAdditionalCosts).Append("\n");
            sb.Append("  CollectCredit: ").Append(CollectCredit).Append("\n");
            sb.Append("  ApplyDiscounts: ").Append(ApplyDiscounts).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            sb.Append("  ManualTransfer: ").Append(ManualTransfer).Append("\n");
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
            return this.Equals(obj as CreateSubscriptionInvoice);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSubscriptionInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionInvoice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
                ) && 
                (
                    this.Instant == other.Instant ||
                    this.Instant != null &&
                    this.Instant.Equals(other.Instant)
                ) && 
                (
                    this.Due == other.Due ||
                    this.Due != null &&
                    this.Due.Equals(other.Due)
                ) && 
                (
                    this.PlanManual == other.PlanManual ||
                    this.PlanManual != null &&
                    this.PlanManual.Equals(other.PlanManual)
                ) && 
                (
                    this.CollectAdditionalCosts == other.CollectAdditionalCosts ||
                    this.CollectAdditionalCosts != null &&
                    this.CollectAdditionalCosts.Equals(other.CollectAdditionalCosts)
                ) && 
                (
                    this.CollectCredit == other.CollectCredit ||
                    this.CollectCredit != null &&
                    this.CollectCredit.Equals(other.CollectCredit)
                ) && 
                (
                    this.ApplyDiscounts == other.ApplyDiscounts ||
                    this.ApplyDiscounts != null &&
                    this.ApplyDiscounts.Equals(other.ApplyDiscounts)
                ) && 
                (
                    this.OrderLines == other.OrderLines ||
                    this.OrderLines != null &&
                    this.OrderLines.SequenceEqual(other.OrderLines)
                ) && 
                (
                    this.ManualTransfer == other.ManualTransfer ||
                    this.ManualTransfer != null &&
                    this.ManualTransfer.Equals(other.ManualTransfer)
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
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                if (this.Instant != null)
                    hash = hash * 59 + this.Instant.GetHashCode();
                if (this.Due != null)
                    hash = hash * 59 + this.Due.GetHashCode();
                if (this.PlanManual != null)
                    hash = hash * 59 + this.PlanManual.GetHashCode();
                if (this.CollectAdditionalCosts != null)
                    hash = hash * 59 + this.CollectAdditionalCosts.GetHashCode();
                if (this.CollectCredit != null)
                    hash = hash * 59 + this.CollectCredit.GetHashCode();
                if (this.ApplyDiscounts != null)
                    hash = hash * 59 + this.ApplyDiscounts.GetHashCode();
                if (this.OrderLines != null)
                    hash = hash * 59 + this.OrderLines.GetHashCode();
                if (this.ManualTransfer != null)
                    hash = hash * 59 + this.ManualTransfer.GetHashCode();
                return hash;
            }
        }
    }

}
