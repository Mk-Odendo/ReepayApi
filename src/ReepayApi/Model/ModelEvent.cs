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
    /// ModelEvent
    /// </summary>
    [DataContract]
    public partial class ModelEvent :  IEquatable<ModelEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEvent" /> class.
        /// </summary>
        [JsonConstructor]
        protected ModelEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEvent" /> class.
        /// </summary>
        /// <param name="Created">When the event happened, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. (required).</param>
        public ModelEvent(DateTime? Created = null)
        {
            // to ensure "Created" is required (not null)
            if (Created == null)
            {
                throw new InvalidDataException("Created is a required property for ModelEvent and cannot be null");
            }
            else
            {
                this.Created = Created;
            }
        }
        
        /// <summary>
        /// Unique event id assigned by Reepay
        /// </summary>
        /// <value>Unique event id assigned by Reepay</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Customer handle
        /// </summary>
        /// <value>Customer handle</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; private set; }
        /// <summary>
        /// Subscription handle
        /// </summary>
        /// <value>Subscription handle</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; private set; }
        /// <summary>
        /// Invoice id
        /// </summary>
        /// <value>Invoice id</value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public string Invoice { get; private set; }
        /// <summary>
        /// When the event happened, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When the event happened, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// The event type (see documentation)
        /// </summary>
        /// <value>The event type (see documentation)</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public string EventType { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(obj as ModelEvent);
        }

        /// <summary>
        /// Returns true if ModelEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                return hash;
            }
        }
    }

}
