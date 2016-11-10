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
    /// UserLogin
    /// </summary>
    [DataContract]
    public partial class UserLogin :  IEquatable<UserLogin>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogin" /> class.
        /// </summary>
        [JsonConstructor]
        protected UserLogin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogin" /> class.
        /// </summary>
        /// <param name="User">Logged in user (required).</param>
        /// <param name="Account">Account logged into (required).</param>
        /// <param name="Organisation">Organisation for account logged into (required).</param>
        /// <param name="Organisations">List of organisations for user (required).</param>
        /// <param name="Groups">List user groups (required).</param>
        /// <param name="Permissions">List user permissions (required).</param>
        public UserLogin(User User = null, AccountLogin Account = null, Organisation Organisation = null, List<OrganisationLogin> Organisations = null, List<string> Groups = null, List<string> Permissions = null)
        {
            // to ensure "User" is required (not null)
            if (User == null)
            {
                throw new InvalidDataException("User is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.User = User;
            }
            // to ensure "Account" is required (not null)
            if (Account == null)
            {
                throw new InvalidDataException("Account is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.Account = Account;
            }
            // to ensure "Organisation" is required (not null)
            if (Organisation == null)
            {
                throw new InvalidDataException("Organisation is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.Organisation = Organisation;
            }
            // to ensure "Organisations" is required (not null)
            if (Organisations == null)
            {
                throw new InvalidDataException("Organisations is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.Organisations = Organisations;
            }
            // to ensure "Groups" is required (not null)
            if (Groups == null)
            {
                throw new InvalidDataException("Groups is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.Groups = Groups;
            }
            // to ensure "Permissions" is required (not null)
            if (Permissions == null)
            {
                throw new InvalidDataException("Permissions is a required property for UserLogin and cannot be null");
            }
            else
            {
                this.Permissions = Permissions;
            }
        }
        
        /// <summary>
        /// Authentication token to use in X-Auth-Token
        /// </summary>
        /// <value>Authentication token to use in X-Auth-Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; private set; }
        /// <summary>
        /// Logged in user
        /// </summary>
        /// <value>Logged in user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Account logged into
        /// </summary>
        /// <value>Account logged into</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public AccountLogin Account { get; set; }
        /// <summary>
        /// Organisation for account logged into
        /// </summary>
        /// <value>Organisation for account logged into</value>
        [DataMember(Name="organisation", EmitDefaultValue=false)]
        public Organisation Organisation { get; set; }
        /// <summary>
        /// List of organisations for user
        /// </summary>
        /// <value>List of organisations for user</value>
        [DataMember(Name="organisations", EmitDefaultValue=false)]
        public List<OrganisationLogin> Organisations { get; set; }
        /// <summary>
        /// List user groups
        /// </summary>
        /// <value>List user groups</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// List user permissions
        /// </summary>
        /// <value>List user permissions</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
        /// <summary>
        /// Token time-to-live in minutes
        /// </summary>
        /// <value>Token time-to-live in minutes</value>
        [DataMember(Name="token_ttl", EmitDefaultValue=false)]
        public int? TokenTtl { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLogin {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Organisation: ").Append(Organisation).Append("\n");
            sb.Append("  Organisations: ").Append(Organisations).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  TokenTtl: ").Append(TokenTtl).Append("\n");
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
            return this.Equals(obj as UserLogin);
        }

        /// <summary>
        /// Returns true if UserLogin instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLogin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLogin other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Organisation == other.Organisation ||
                    this.Organisation != null &&
                    this.Organisation.Equals(other.Organisation)
                ) && 
                (
                    this.Organisations == other.Organisations ||
                    this.Organisations != null &&
                    this.Organisations.SequenceEqual(other.Organisations)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.TokenTtl == other.TokenTtl ||
                    this.TokenTtl != null &&
                    this.TokenTtl.Equals(other.TokenTtl)
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
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Organisation != null)
                    hash = hash * 59 + this.Organisation.GetHashCode();
                if (this.Organisations != null)
                    hash = hash * 59 + this.Organisations.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.TokenTtl != null)
                    hash = hash * 59 + this.TokenTtl.GetHashCode();
                return hash;
            }
        }
    }

}