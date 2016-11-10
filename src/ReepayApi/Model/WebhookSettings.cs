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
    /// WebhookSettings
    /// </summary>
    [DataContract]
    public partial class WebhookSettings :  IEquatable<WebhookSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSettings" /> class.
        /// </summary>
        [JsonConstructor]
        protected WebhookSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSettings" /> class.
        /// </summary>
        /// <param name="Urls">Webhook urls (required).</param>
        /// <param name="AlertEmails">Optional list of emails to send alert to if webhook fails.</param>
        /// <param name="AlertCount">Number of requests to perform before alert email is sent, must be greater than or equal to four (1 hour).</param>
        public WebhookSettings(List<string> Urls = null, List<string> AlertEmails = null, int? AlertCount = null)
        {
            // to ensure "Urls" is required (not null)
            if (Urls == null)
            {
                throw new InvalidDataException("Urls is a required property for WebhookSettings and cannot be null");
            }
            else
            {
                this.Urls = Urls;
            }
            this.AlertEmails = AlertEmails;
            this.AlertCount = AlertCount;
        }
        
        /// <summary>
        /// Webhook urls
        /// </summary>
        /// <value>Webhook urls</value>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<string> Urls { get; set; }
        /// <summary>
        /// Optional HTTP Basic Auth username
        /// </summary>
        /// <value>Optional HTTP Basic Auth username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; private set; }
        /// <summary>
        /// Optional HTTP Basic Auth password
        /// </summary>
        /// <value>Optional HTTP Basic Auth password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; private set; }
        /// <summary>
        /// Webhook disabled
        /// </summary>
        /// <value>Webhook disabled</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; private set; }
        /// <summary>
        /// Webhook secret used for signature
        /// </summary>
        /// <value>Webhook secret used for signature</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; private set; }
        /// <summary>
        /// Optional list of emails to send alert to if webhook fails
        /// </summary>
        /// <value>Optional list of emails to send alert to if webhook fails</value>
        [DataMember(Name="alert_emails", EmitDefaultValue=false)]
        public List<string> AlertEmails { get; set; }
        /// <summary>
        /// Number of requests to perform before alert email is sent, must be greater than or equal to four (1 hour)
        /// </summary>
        /// <value>Number of requests to perform before alert email is sent, must be greater than or equal to four (1 hour)</value>
        [DataMember(Name="alert_count", EmitDefaultValue=false)]
        public int? AlertCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSettings {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  AlertEmails: ").Append(AlertEmails).Append("\n");
            sb.Append("  AlertCount: ").Append(AlertCount).Append("\n");
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
            return this.Equals(obj as WebhookSettings);
        }

        /// <summary>
        /// Returns true if WebhookSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Urls == other.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(other.Urls)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) && 
                (
                    this.Secret == other.Secret ||
                    this.Secret != null &&
                    this.Secret.Equals(other.Secret)
                ) && 
                (
                    this.AlertEmails == other.AlertEmails ||
                    this.AlertEmails != null &&
                    this.AlertEmails.SequenceEqual(other.AlertEmails)
                ) && 
                (
                    this.AlertCount == other.AlertCount ||
                    this.AlertCount != null &&
                    this.AlertCount.Equals(other.AlertCount)
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
                if (this.Urls != null)
                    hash = hash * 59 + this.Urls.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();
                if (this.Secret != null)
                    hash = hash * 59 + this.Secret.GetHashCode();
                if (this.AlertEmails != null)
                    hash = hash * 59 + this.AlertEmails.GetHashCode();
                if (this.AlertCount != null)
                    hash = hash * 59 + this.AlertCount.GetHashCode();
                return hash;
            }
        }
    }

}
