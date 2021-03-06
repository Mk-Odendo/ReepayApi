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
    /// RefundInvoice
    /// </summary>
    [DataContract]
    public partial class RefundInvoice :  IEquatable<RefundInvoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoice" /> class.
        /// </summary>
        [JsonConstructor]
        protected RefundInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundInvoice" /> class.
        /// </summary>
        /// <param name="NoteLines">Refund credit note lines (required).</param>
        /// <param name="ManualTransfer">Optional manual tranfer. If given no refund will be performed on potential online settled transaction like card transaction..</param>
        public RefundInvoice(List<CreateCreditNoteLine> NoteLines = null, ManualRefundTransfer ManualTransfer = null)
        {
            // to ensure "NoteLines" is required (not null)
            if (NoteLines == null)
            {
                throw new InvalidDataException("NoteLines is a required property for RefundInvoice and cannot be null");
            }
            else
            {
                this.NoteLines = NoteLines;
            }
            this.ManualTransfer = ManualTransfer;
        }
        
        /// <summary>
        /// Refund credit note lines
        /// </summary>
        /// <value>Refund credit note lines</value>
        [DataMember(Name="note_lines", EmitDefaultValue=false)]
        public List<CreateCreditNoteLine> NoteLines { get; set; }
        /// <summary>
        /// Optional manual tranfer. If given no refund will be performed on potential online settled transaction like card transaction.
        /// </summary>
        /// <value>Optional manual tranfer. If given no refund will be performed on potential online settled transaction like card transaction.</value>
        [DataMember(Name="manual_transfer", EmitDefaultValue=false)]
        public ManualRefundTransfer ManualTransfer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundInvoice {\n");
            sb.Append("  NoteLines: ").Append(NoteLines).Append("\n");
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
            return this.Equals(obj as RefundInvoice);
        }

        /// <summary>
        /// Returns true if RefundInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of RefundInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundInvoice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NoteLines == other.NoteLines ||
                    this.NoteLines != null &&
                    this.NoteLines.SequenceEqual(other.NoteLines)
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
                if (this.NoteLines != null)
                    hash = hash * 59 + this.NoteLines.GetHashCode();
                if (this.ManualTransfer != null)
                    hash = hash * 59 + this.ManualTransfer.GetHashCode();
                return hash;
            }
        }
    }

}
