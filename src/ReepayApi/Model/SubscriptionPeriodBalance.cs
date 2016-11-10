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
    /// SubscriptionPeriodBalance
    /// </summary>
    [DataContract]
    public partial class SubscriptionPeriodBalance :  IEquatable<SubscriptionPeriodBalance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPeriodBalance" /> class.
        /// </summary>
        /// <param name="Date">Date in period for this period balance.</param>
        /// <param name="Invoice">Invoice for period, if it exists. See &#x60;period_from&#x60; and &#x60;period_to&#x60; for period start and end..</param>
        /// <param name="Paid">The plan amount paid and settled for this period.</param>
        /// <param name="Consumed">The partial plan amount consumed up to date for this period.</param>
        /// <param name="Remaining">The partial plan amount remaining for this period. This amount can be refunded in the case the subscription is expired or put on hold and the amount has been paid..</param>
        /// <param name="OnlineRefundable">The amount that can be online refunded on the subscription.</param>
        public SubscriptionPeriodBalance(DateTime? Date = null, Invoice Invoice = null, int? Paid = null, int? Consumed = null, int? Remaining = null, int? OnlineRefundable = null)
        {
            this.Date = Date;
            this.Invoice = Invoice;
            this.Paid = Paid;
            this.Consumed = Consumed;
            this.Remaining = Remaining;
            this.OnlineRefundable = OnlineRefundable;
        }
        
        /// <summary>
        /// Date in period for this period balance
        /// </summary>
        /// <value>Date in period for this period balance</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Invoice for period, if it exists. See &#x60;period_from&#x60; and &#x60;period_to&#x60; for period start and end.
        /// </summary>
        /// <value>Invoice for period, if it exists. See &#x60;period_from&#x60; and &#x60;period_to&#x60; for period start and end.</value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public Invoice Invoice { get; set; }
        /// <summary>
        /// The plan amount paid and settled for this period
        /// </summary>
        /// <value>The plan amount paid and settled for this period</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public int? Paid { get; set; }
        /// <summary>
        /// The partial plan amount consumed up to date for this period
        /// </summary>
        /// <value>The partial plan amount consumed up to date for this period</value>
        [DataMember(Name="consumed", EmitDefaultValue=false)]
        public int? Consumed { get; set; }
        /// <summary>
        /// The partial plan amount remaining for this period. This amount can be refunded in the case the subscription is expired or put on hold and the amount has been paid.
        /// </summary>
        /// <value>The partial plan amount remaining for this period. This amount can be refunded in the case the subscription is expired or put on hold and the amount has been paid.</value>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public int? Remaining { get; set; }
        /// <summary>
        /// The amount that can be online refunded on the subscription
        /// </summary>
        /// <value>The amount that can be online refunded on the subscription</value>
        [DataMember(Name="online_refundable", EmitDefaultValue=false)]
        public int? OnlineRefundable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPeriodBalance {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  Consumed: ").Append(Consumed).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  OnlineRefundable: ").Append(OnlineRefundable).Append("\n");
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
            return this.Equals(obj as SubscriptionPeriodBalance);
        }

        /// <summary>
        /// Returns true if SubscriptionPeriodBalance instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionPeriodBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPeriodBalance other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) && 
                (
                    this.Consumed == other.Consumed ||
                    this.Consumed != null &&
                    this.Consumed.Equals(other.Consumed)
                ) && 
                (
                    this.Remaining == other.Remaining ||
                    this.Remaining != null &&
                    this.Remaining.Equals(other.Remaining)
                ) && 
                (
                    this.OnlineRefundable == other.OnlineRefundable ||
                    this.OnlineRefundable != null &&
                    this.OnlineRefundable.Equals(other.OnlineRefundable)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                if (this.Consumed != null)
                    hash = hash * 59 + this.Consumed.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                if (this.OnlineRefundable != null)
                    hash = hash * 59 + this.OnlineRefundable.GetHashCode();
                return hash;
            }
        }
    }

}
