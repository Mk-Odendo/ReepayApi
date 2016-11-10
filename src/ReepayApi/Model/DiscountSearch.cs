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
    /// A page in a paginated discount search
    /// </summary>
    [DataContract]
    public partial class DiscountSearch :  IEquatable<DiscountSearch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountSearch" /> class.
        /// </summary>
        [JsonConstructor]
        protected DiscountSearch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountSearch" /> class.
        /// </summary>
        /// <param name="Page">Number of current page in paginated list (required).</param>
        /// <param name="Size">Page size in paginated list (required).</param>
        /// <param name="Count">Number of elements in current page (required).</param>
        /// <param name="Search">Optional search expression used.</param>
        /// <param name="Sort">Optional sort expression used.</param>
        /// <param name="Content">List of discounts for current page (required).</param>
        /// <param name="TotalElements">Total number of elements in paginated list (required).</param>
        /// <param name="TotalPages">Total number of pages in paginated list (required).</param>
        public DiscountSearch(int? Page = null, int? Size = null, int? Count = null, string Search = null, string Sort = null, List<Discount> Content = null, long? TotalElements = null, int? TotalPages = null)
        {
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "TotalElements" is required (not null)
            if (TotalElements == null)
            {
                throw new InvalidDataException("TotalElements is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.TotalElements = TotalElements;
            }
            // to ensure "TotalPages" is required (not null)
            if (TotalPages == null)
            {
                throw new InvalidDataException("TotalPages is a required property for DiscountSearch and cannot be null");
            }
            else
            {
                this.TotalPages = TotalPages;
            }
            this.Search = Search;
            this.Sort = Sort;
        }
        
        /// <summary>
        /// Number of current page in paginated list
        /// </summary>
        /// <value>Number of current page in paginated list</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// Page size in paginated list
        /// </summary>
        /// <value>Page size in paginated list</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        /// <summary>
        /// Number of elements in current page
        /// </summary>
        /// <value>Number of elements in current page</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Optional search expression used
        /// </summary>
        /// <value>Optional search expression used</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public string Search { get; set; }
        /// <summary>
        /// Optional sort expression used
        /// </summary>
        /// <value>Optional sort expression used</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }
        /// <summary>
        /// List of discounts for current page
        /// </summary>
        /// <value>List of discounts for current page</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<Discount> Content { get; set; }
        /// <summary>
        /// Total number of elements in paginated list
        /// </summary>
        /// <value>Total number of elements in paginated list</value>
        [DataMember(Name="total_elements", EmitDefaultValue=false)]
        public long? TotalElements { get; set; }
        /// <summary>
        /// Total number of pages in paginated list
        /// </summary>
        /// <value>Total number of pages in paginated list</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountSearch {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(obj as DiscountSearch);
        }

        /// <summary>
        /// Returns true if DiscountSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscountSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountSearch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Search == other.Search ||
                    this.Search != null &&
                    this.Search.Equals(other.Search)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
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
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Search != null)
                    hash = hash * 59 + this.Search.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.TotalElements != null)
                    hash = hash * 59 + this.TotalElements.GetHashCode();
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                return hash;
            }
        }
    }

}
