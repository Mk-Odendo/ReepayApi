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
    /// CreateCustomer
    /// </summary>
    [DataContract]
    public partial class CreateCustomer :  IEquatable<CreateCustomer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer" /> class.
        /// </summary>
        /// <param name="Email">Customer email.</param>
        /// <param name="Address">Customer address.</param>
        /// <param name="Address2">Customer address2.</param>
        /// <param name="City">Customer city.</param>
        /// <param name="Country">Customer country in ISO 3166-1 alpha-2.</param>
        /// <param name="Phone">Customer phone number.</param>
        /// <param name="Company">Customer company.</param>
        /// <param name="Vat">Customer vat number.</param>
        /// <param name="Handle">Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. Must be provided if generate_handle is not defined. (required).</param>
        /// <param name="Test">Test flag. If given it will be verified that the account state matches the intended create state. (default to false).</param>
        /// <param name="FirstName">Customer first name.</param>
        /// <param name="LastName">Customer last name.</param>
        /// <param name="PostalCode">Customer postal code.</param>
        /// <param name="GenerateHandle">Auto generate handle on the form cust-[sequence_number] (default to false).</param>
        public CreateCustomer(string Email = null, string Address = null, string Address2 = null, string City = null, string Country = null, string Phone = null, string Company = null, string Vat = null, string Handle = null, bool? Test = null, string FirstName = null, string LastName = null, string PostalCode = null, bool? GenerateHandle = null)
        {
            // to ensure "Handle" is required (not null)
            if (Handle == null)
            {
                throw new InvalidDataException("Handle is a required property for CreateCustomer and cannot be null");
            }
            else
            {
                this.Handle = Handle;
            }
            this.Email = Email;
            this.Address = Address;
            this.Address2 = Address2;
            this.City = City;
            this.Country = Country;
            this.Phone = Phone;
            this.Company = Company;
            this.Vat = Vat;
            // use default value if no "Test" provided
            if (Test == null)
            {
                this.Test = false;
            }
            else
            {
                this.Test = Test;
            }
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PostalCode = PostalCode;
            // use default value if no "GenerateHandle" provided
            if (GenerateHandle == null)
            {
                this.GenerateHandle = false;
            }
            else
            {
                this.GenerateHandle = GenerateHandle;
            }
        }
        
        /// <summary>
        /// Customer email
        /// </summary>
        /// <value>Customer email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Customer address
        /// </summary>
        /// <value>Customer address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Customer address2
        /// </summary>
        /// <value>Customer address2</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }
        /// <summary>
        /// Customer city
        /// </summary>
        /// <value>Customer city</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Customer country in ISO 3166-1 alpha-2
        /// </summary>
        /// <value>Customer country in ISO 3166-1 alpha-2</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Customer phone number
        /// </summary>
        /// <value>Customer phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Customer company
        /// </summary>
        /// <value>Customer company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// Customer vat number
        /// </summary>
        /// <value>Customer vat number</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public string Vat { get; set; }
        /// <summary>
        /// Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. Must be provided if generate_handle is not defined.
        /// </summary>
        /// <value>Per account unique handle for the customer. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. Must be provided if generate_handle is not defined.</value>
        [DataMember(Name="handle", EmitDefaultValue=false)]
        public string Handle { get; set; }
        /// <summary>
        /// Test flag. If given it will be verified that the account state matches the intended create state.
        /// </summary>
        /// <value>Test flag. If given it will be verified that the account state matches the intended create state.</value>
        [DataMember(Name="test", EmitDefaultValue=false)]
        public bool? Test { get; set; }
        /// <summary>
        /// Customer first name
        /// </summary>
        /// <value>Customer first name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Customer last name
        /// </summary>
        /// <value>Customer last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Customer postal code
        /// </summary>
        /// <value>Customer postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Auto generate handle on the form cust-[sequence_number]
        /// </summary>
        /// <value>Auto generate handle on the form cust-[sequence_number]</value>
        [DataMember(Name="generate_handle", EmitDefaultValue=false)]
        public bool? GenerateHandle { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomer {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Handle: ").Append(Handle).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  GenerateHandle: ").Append(GenerateHandle).Append("\n");
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
            return this.Equals(obj as CreateCustomer);
        }

        /// <summary>
        /// Returns true if CreateCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Vat == other.Vat ||
                    this.Vat != null &&
                    this.Vat.Equals(other.Vat)
                ) && 
                (
                    this.Handle == other.Handle ||
                    this.Handle != null &&
                    this.Handle.Equals(other.Handle)
                ) && 
                (
                    this.Test == other.Test ||
                    this.Test != null &&
                    this.Test.Equals(other.Test)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.GenerateHandle == other.GenerateHandle ||
                    this.GenerateHandle != null &&
                    this.GenerateHandle.Equals(other.GenerateHandle)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Vat != null)
                    hash = hash * 59 + this.Vat.GetHashCode();
                if (this.Handle != null)
                    hash = hash * 59 + this.Handle.GetHashCode();
                if (this.Test != null)
                    hash = hash * 59 + this.Test.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.GenerateHandle != null)
                    hash = hash * 59 + this.GenerateHandle.GetHashCode();
                return hash;
            }
        }
    }

}
