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
    /// ManualSettleTransfer
    /// </summary>
    [DataContract]
    public partial class ManualSettleTransfer :  IEquatable<ManualSettleTransfer>
    {
        /// <summary>
        /// The payment method used for the offline manual transaction, allowable values: `cash`, `bank_transfer`, `check`, `other`
        /// </summary>
        /// <value>The payment method used for the offline manual transaction, allowable values: `cash`, `bank_transfer`, `check`, `other`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum Cash for "cash"
            /// </summary>
            [EnumMember(Value = "cash")]
            Cash,
            
            /// <summary>
            /// Enum Banktransfer for "bank_transfer"
            /// </summary>
            [EnumMember(Value = "bank_transfer")]
            Banktransfer,
            
            /// <summary>
            /// Enum Check for "check"
            /// </summary>
            [EnumMember(Value = "check")]
            Check,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other
        }

        /// <summary>
        /// The payment method used for the offline manual transaction, allowable values: `cash`, `bank_transfer`, `check`, `other`
        /// </summary>
        /// <value>The payment method used for the offline manual transaction, allowable values: `cash`, `bank_transfer`, `check`, `other`</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualSettleTransfer" /> class.
        /// </summary>
        [JsonConstructor]
        protected ManualSettleTransfer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualSettleTransfer" /> class.
        /// </summary>
        /// <param name="Comment">Optional comment for manual transaction.</param>
        /// <param name="Reference">Optional reference for the manual transaction.</param>
        /// <param name="Method">The payment method used for the offline manual transaction, allowable values: &#x60;cash&#x60;, &#x60;bank_transfer&#x60;, &#x60;check&#x60;, &#x60;other&#x60; (required).</param>
        /// <param name="PaymentDate">When the manual transaction was performed on the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60; (required).</param>
        public ManualSettleTransfer(string Comment = null, string Reference = null, MethodEnum? Method = null, string PaymentDate = null)
        {
            // to ensure "Method" is required (not null)
            if (Method == null)
            {
                throw new InvalidDataException("Method is a required property for ManualSettleTransfer and cannot be null");
            }
            else
            {
                this.Method = Method;
            }
            // to ensure "PaymentDate" is required (not null)
            if (PaymentDate == null)
            {
                throw new InvalidDataException("PaymentDate is a required property for ManualSettleTransfer and cannot be null");
            }
            else
            {
                this.PaymentDate = PaymentDate;
            }
            this.Comment = Comment;
            this.Reference = Reference;
        }
        
        /// <summary>
        /// Optional comment for manual transaction
        /// </summary>
        /// <value>Optional comment for manual transaction</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Optional reference for the manual transaction
        /// </summary>
        /// <value>Optional reference for the manual transaction</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }
        /// <summary>
        /// When the manual transaction was performed on the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60;
        /// </summary>
        /// <value>When the manual transaction was performed on the form &#x60;yyyy-MM-dd&#x60;, &#x60;yyyyMMdd&#x60;, &#x60;yyyy-MM-ddTHH:mm&#x60; and &#x60;yyyy-MM-ddTHH:mm:ss&#x60;</value>
        [DataMember(Name="payment_date", EmitDefaultValue=false)]
        public string PaymentDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualSettleTransfer {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
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
            return this.Equals(obj as ManualSettleTransfer);
        }

        /// <summary>
        /// Returns true if ManualSettleTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of ManualSettleTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualSettleTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.PaymentDate == other.PaymentDate ||
                    this.PaymentDate != null &&
                    this.PaymentDate.Equals(other.PaymentDate)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.PaymentDate != null)
                    hash = hash * 59 + this.PaymentDate.GetHashCode();
                return hash;
            }
        }
    }

}
