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
    /// CreateCustomerNote
    /// </summary>
    [DataContract]
    public partial class CreateCustomerNote :  IEquatable<CreateCustomerNote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerNote" /> class.
        /// </summary>
        [JsonConstructor]
        public CreateCustomerNote()
        {
        }
        
        /// <summary>
        /// Customer note text. Maximum 4096 characters.
        /// </summary>
        /// <value>Customer note text. Maximum 4096 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; private set; }
        /// <summary>
        /// User name of the note creator
        /// </summary>
        /// <value>User name of the note creator</value>
        [DataMember(Name="user_name", EmitDefaultValue=false)]
        public string UserName { get; private set; }
        /// <summary>
        /// User email of the note creator
        /// </summary>
        /// <value>User email of the note creator</value>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        public string UserEmail { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerNote {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
            return this.Equals(obj as CreateCustomerNote);
        }

        /// <summary>
        /// Returns true if CreateCustomerNote instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomerNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomerNote other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.UserEmail == other.UserEmail ||
                    this.UserEmail != null &&
                    this.UserEmail.Equals(other.UserEmail)
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
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.UserEmail != null)
                    hash = hash * 59 + this.UserEmail.GetHashCode();
                return hash;
            }
        }
    }

}
