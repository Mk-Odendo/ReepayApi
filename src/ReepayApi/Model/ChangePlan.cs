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
    /// ChangePlan
    /// </summary>
    [DataContract]
    public partial class ChangePlan :  IEquatable<ChangePlan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlan" /> class.
        /// </summary>
        [JsonConstructor]
        protected ChangePlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePlan" /> class.
        /// </summary>
        /// <param name="Plan">The handle of the plan to change to (required).</param>
        public ChangePlan(string Plan = null)
        {
            // to ensure "Plan" is required (not null)
            if (Plan == null)
            {
                throw new InvalidDataException("Plan is a required property for ChangePlan and cannot be null");
            }
            else
            {
                this.Plan = Plan;
            }
        }
        
        /// <summary>
        /// The handle of the plan to change to
        /// </summary>
        /// <value>The handle of the plan to change to</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePlan {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
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
            return this.Equals(obj as ChangePlan);
        }

        /// <summary>
        /// Returns true if ChangePlan instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePlan other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
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
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                return hash;
            }
        }
    }

}
