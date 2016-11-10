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
    /// Invoice
    /// </summary>
    [DataContract]
    public partial class Invoice :  IEquatable<Invoice>
    {
        /// <summary>
        /// The invoice state one of the following: `pending`, `dunning`, `settled`, `cancelled`, `failed`
        /// </summary>
        /// <value>The invoice state one of the following: `pending`, `dunning`, `settled`, `cancelled`, `failed`</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Dunning for "dunning"
            /// </summary>
            [EnumMember(Value = "dunning")]
            Dunning,
            
            /// <summary>
            /// Enum Settled for "settled"
            /// </summary>
            [EnumMember(Value = "settled")]
            Settled,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed
        }

        /// <summary>
        /// The invoice state one of the following: `pending`, `dunning`, `settled`, `cancelled`, `failed`
        /// </summary>
        /// <value>The invoice state one of the following: `pending`, `dunning`, `settled`, `cancelled`, `failed`</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        [JsonConstructor]
        protected Invoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="Due">When is the invoice due, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. (required).</param>
        /// <param name="Failed">When the invoice failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="Settled">When the invoice settled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="Cancelled">When the invoice was cancelled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="Credits">Credits applied to invoice (required).</param>
        /// <param name="Adjustments">Invoice adjustments.</param>
        /// <param name="Created">When the invoice was created, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format. (required).</param>
        /// <param name="DunningPlan">Dunning plan handle.</param>
        /// <param name="DiscountAmount">The potential discount amount deducted from the invoice amount including VAT (required).</param>
        /// <param name="PeriodNumber">The subscription period this invoice is for.</param>
        /// <param name="OrderLines">Order lines for invoice sorted by descending timestamp (required).</param>
        /// <param name="AdditionalCosts">Additional costs for invoice (required).</param>
        /// <param name="CardTransactions">Invoice card transactions (required).</param>
        /// <param name="ManualTransactions">Invoice manual transactions (required).</param>
        /// <param name="CreditNotes">Invoice credit notes.</param>
        /// <param name="DunningStart">When dunning for the invoice was started, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="DunningCount">Number of dunning events for invoice (number of reminders sent).</param>
        /// <param name="DunningExpired">When dunning for the invoice expired, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="PeriodFrom">The start of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        /// <param name="PeriodTo">The end of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format..</param>
        public Invoice(DateTime? Due = null, DateTime? Failed = null, DateTime? Settled = null, DateTime? Cancelled = null, List<CreditInvoice> Credits = null, List<InvoiceAdjustment> Adjustments = null, DateTime? Created = null, string DunningPlan = null, int? DiscountAmount = null, int? PeriodNumber = null, List<OrderLine> OrderLines = null, List<string> AdditionalCosts = null, List<CardTransaction> CardTransactions = null, List<ManualTransaction> ManualTransactions = null, List<InvoiceCreditNote> CreditNotes = null, DateTime? DunningStart = null, int? DunningCount = null, DateTime? DunningExpired = null, DateTime? PeriodFrom = null, DateTime? PeriodTo = null)
        {
            // to ensure "Due" is required (not null)
            if (Due == null)
            {
                throw new InvalidDataException("Due is a required property for Invoice and cannot be null");
            }
            else
            {
                this.Due = Due;
            }
            // to ensure "Credits" is required (not null)
            if (Credits == null)
            {
                throw new InvalidDataException("Credits is a required property for Invoice and cannot be null");
            }
            else
            {
                this.Credits = Credits;
            }
            // to ensure "Created" is required (not null)
            if (Created == null)
            {
                throw new InvalidDataException("Created is a required property for Invoice and cannot be null");
            }
            else
            {
                this.Created = Created;
            }
            // to ensure "DiscountAmount" is required (not null)
            if (DiscountAmount == null)
            {
                throw new InvalidDataException("DiscountAmount is a required property for Invoice and cannot be null");
            }
            else
            {
                this.DiscountAmount = DiscountAmount;
            }
            // to ensure "OrderLines" is required (not null)
            if (OrderLines == null)
            {
                throw new InvalidDataException("OrderLines is a required property for Invoice and cannot be null");
            }
            else
            {
                this.OrderLines = OrderLines;
            }
            // to ensure "AdditionalCosts" is required (not null)
            if (AdditionalCosts == null)
            {
                throw new InvalidDataException("AdditionalCosts is a required property for Invoice and cannot be null");
            }
            else
            {
                this.AdditionalCosts = AdditionalCosts;
            }
            // to ensure "CardTransactions" is required (not null)
            if (CardTransactions == null)
            {
                throw new InvalidDataException("CardTransactions is a required property for Invoice and cannot be null");
            }
            else
            {
                this.CardTransactions = CardTransactions;
            }
            // to ensure "ManualTransactions" is required (not null)
            if (ManualTransactions == null)
            {
                throw new InvalidDataException("ManualTransactions is a required property for Invoice and cannot be null");
            }
            else
            {
                this.ManualTransactions = ManualTransactions;
            }
            this.Failed = Failed;
            this.Settled = Settled;
            this.Cancelled = Cancelled;
            this.Adjustments = Adjustments;
            this.DunningPlan = DunningPlan;
            this.PeriodNumber = PeriodNumber;
            this.CreditNotes = CreditNotes;
            this.DunningStart = DunningStart;
            this.DunningCount = DunningCount;
            this.DunningExpired = DunningExpired;
            this.PeriodFrom = PeriodFrom;
            this.PeriodTo = PeriodTo;
        }
        
        /// <summary>
        /// Invoice id assigned by Reepay
        /// </summary>
        /// <value>Invoice id assigned by Reepay</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Customer handle
        /// </summary>
        /// <value>Customer handle</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; private set; }
        /// <summary>
        /// Subscription handle, will be null for a one-time customer invoice
        /// </summary>
        /// <value>Subscription handle, will be null for a one-time customer invoice</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; private set; }
        /// <summary>
        /// Subscription plan handle for the plan used to automatically create the invoice. Will be null for one-time invoices.
        /// </summary>
        /// <value>Subscription plan handle for the plan used to automatically create the invoice. Will be null for one-time invoices.</value>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; private set; }
        /// <summary>
        /// The invoice amount including VAT
        /// </summary>
        /// <value>The invoice amount including VAT</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; private set; }
        /// <summary>
        /// Sequential invoice number
        /// </summary>
        /// <value>Sequential invoice number</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; private set; }
        /// <summary>
        /// Currency for the account in [ISO 4217](http://da.wikipedia.org/wiki/ISO_4217) three letter alpha code
        /// </summary>
        /// <value>Currency for the account in [ISO 4217](http://da.wikipedia.org/wiki/ISO_4217) three letter alpha code</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }
        /// <summary>
        /// When is the invoice due, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When is the invoice due, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="due", EmitDefaultValue=false)]
        public DateTime? Due { get; set; }
        /// <summary>
        /// When the invoice failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When the invoice failed, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public DateTime? Failed { get; set; }
        /// <summary>
        /// When the invoice settled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When the invoice settled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="settled", EmitDefaultValue=false)]
        public DateTime? Settled { get; set; }
        /// <summary>
        /// When the invoice was cancelled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When the invoice was cancelled, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="cancelled", EmitDefaultValue=false)]
        public DateTime? Cancelled { get; set; }
        /// <summary>
        /// Credits applied to invoice
        /// </summary>
        /// <value>Credits applied to invoice</value>
        [DataMember(Name="credits", EmitDefaultValue=false)]
        public List<CreditInvoice> Credits { get; set; }
        /// <summary>
        /// Invoice adjustments
        /// </summary>
        /// <value>Invoice adjustments</value>
        [DataMember(Name="adjustments", EmitDefaultValue=false)]
        public List<InvoiceAdjustment> Adjustments { get; set; }
        /// <summary>
        /// When the invoice was created, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When the invoice was created, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Subscription plan version
        /// </summary>
        /// <value>Subscription plan version</value>
        [DataMember(Name="plan_version", EmitDefaultValue=false)]
        public int? PlanVersion { get; private set; }
        /// <summary>
        /// Dunning plan handle
        /// </summary>
        /// <value>Dunning plan handle</value>
        [DataMember(Name="dunning_plan", EmitDefaultValue=false)]
        public string DunningPlan { get; set; }
        /// <summary>
        /// The potential discount amount deducted from the invoice amount including VAT
        /// </summary>
        /// <value>The potential discount amount deducted from the invoice amount including VAT</value>
        [DataMember(Name="discount_amount", EmitDefaultValue=false)]
        public int? DiscountAmount { get; set; }
        /// <summary>
        /// The invoice original amount including VAT, may differ from amount if adjustments have been applied for the invoice
        /// </summary>
        /// <value>The invoice original amount including VAT, may differ from amount if adjustments have been applied for the invoice</value>
        [DataMember(Name="org_amount", EmitDefaultValue=false)]
        public int? OrgAmount { get; private set; }
        /// <summary>
        /// The invoice vat amount calculated as rounded summed fractional vats for each orderline
        /// </summary>
        /// <value>The invoice vat amount calculated as rounded summed fractional vats for each orderline</value>
        [DataMember(Name="amount_vat", EmitDefaultValue=false)]
        public int? AmountVat { get; private set; }
        /// <summary>
        /// The invoice amount without vat
        /// </summary>
        /// <value>The invoice amount without vat</value>
        [DataMember(Name="amount_ex_vat", EmitDefaultValue=false)]
        public int? AmountExVat { get; private set; }
        /// <summary>
        /// Settled amount
        /// </summary>
        /// <value>Settled amount</value>
        [DataMember(Name="settled_amount", EmitDefaultValue=false)]
        public int? SettledAmount { get; private set; }
        /// <summary>
        /// Refunded amount
        /// </summary>
        /// <value>Refunded amount</value>
        [DataMember(Name="refunded_amount", EmitDefaultValue=false)]
        public int? RefundedAmount { get; private set; }
        /// <summary>
        /// The subscription period this invoice is for
        /// </summary>
        /// <value>The subscription period this invoice is for</value>
        [DataMember(Name="period_number", EmitDefaultValue=false)]
        public int? PeriodNumber { get; set; }
        /// <summary>
        /// Order lines for invoice sorted by descending timestamp
        /// </summary>
        /// <value>Order lines for invoice sorted by descending timestamp</value>
        [DataMember(Name="order_lines", EmitDefaultValue=false)]
        public List<OrderLine> OrderLines { get; set; }
        /// <summary>
        /// Additional costs for invoice
        /// </summary>
        /// <value>Additional costs for invoice</value>
        [DataMember(Name="additional_costs", EmitDefaultValue=false)]
        public List<string> AdditionalCosts { get; set; }
        /// <summary>
        /// Invoice card transactions
        /// </summary>
        /// <value>Invoice card transactions</value>
        [DataMember(Name="card_transactions", EmitDefaultValue=false)]
        public List<CardTransaction> CardTransactions { get; set; }
        /// <summary>
        /// Invoice manual transactions
        /// </summary>
        /// <value>Invoice manual transactions</value>
        [DataMember(Name="manual_transactions", EmitDefaultValue=false)]
        public List<ManualTransaction> ManualTransactions { get; set; }
        /// <summary>
        /// Invoice credit notes
        /// </summary>
        /// <value>Invoice credit notes</value>
        [DataMember(Name="credit_notes", EmitDefaultValue=false)]
        public List<InvoiceCreditNote> CreditNotes { get; set; }
        /// <summary>
        /// When dunning for the invoice was started, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When dunning for the invoice was started, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="dunning_start", EmitDefaultValue=false)]
        public DateTime? DunningStart { get; set; }
        /// <summary>
        /// Number of dunning events for invoice (number of reminders sent)
        /// </summary>
        /// <value>Number of dunning events for invoice (number of reminders sent)</value>
        [DataMember(Name="dunning_count", EmitDefaultValue=false)]
        public int? DunningCount { get; set; }
        /// <summary>
        /// When dunning for the invoice expired, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>When dunning for the invoice expired, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="dunning_expired", EmitDefaultValue=false)]
        public DateTime? DunningExpired { get; set; }
        /// <summary>
        /// The start of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>The start of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="period_from", EmitDefaultValue=false)]
        public DateTime? PeriodFrom { get; set; }
        /// <summary>
        /// The end of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.
        /// </summary>
        /// <value>The end of billing period if the invoice is for a specific billing period, in [ISO-8601](http://en.wikipedia.org/wiki/ISO_8601) extended offset date-time format.</value>
        [DataMember(Name="period_to", EmitDefaultValue=false)]
        public DateTime? PeriodTo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Due: ").Append(Due).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Settled: ").Append(Settled).Append("\n");
            sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Adjustments: ").Append(Adjustments).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  PlanVersion: ").Append(PlanVersion).Append("\n");
            sb.Append("  DunningPlan: ").Append(DunningPlan).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  OrgAmount: ").Append(OrgAmount).Append("\n");
            sb.Append("  AmountVat: ").Append(AmountVat).Append("\n");
            sb.Append("  AmountExVat: ").Append(AmountExVat).Append("\n");
            sb.Append("  SettledAmount: ").Append(SettledAmount).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  PeriodNumber: ").Append(PeriodNumber).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            sb.Append("  AdditionalCosts: ").Append(AdditionalCosts).Append("\n");
            sb.Append("  CardTransactions: ").Append(CardTransactions).Append("\n");
            sb.Append("  ManualTransactions: ").Append(ManualTransactions).Append("\n");
            sb.Append("  CreditNotes: ").Append(CreditNotes).Append("\n");
            sb.Append("  DunningStart: ").Append(DunningStart).Append("\n");
            sb.Append("  DunningCount: ").Append(DunningCount).Append("\n");
            sb.Append("  DunningExpired: ").Append(DunningExpired).Append("\n");
            sb.Append("  PeriodFrom: ").Append(PeriodFrom).Append("\n");
            sb.Append("  PeriodTo: ").Append(PeriodTo).Append("\n");
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
            return this.Equals(obj as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="other">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice other)
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
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Due == other.Due ||
                    this.Due != null &&
                    this.Due.Equals(other.Due)
                ) && 
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) && 
                (
                    this.Settled == other.Settled ||
                    this.Settled != null &&
                    this.Settled.Equals(other.Settled)
                ) && 
                (
                    this.Cancelled == other.Cancelled ||
                    this.Cancelled != null &&
                    this.Cancelled.Equals(other.Cancelled)
                ) && 
                (
                    this.Credits == other.Credits ||
                    this.Credits != null &&
                    this.Credits.SequenceEqual(other.Credits)
                ) && 
                (
                    this.Adjustments == other.Adjustments ||
                    this.Adjustments != null &&
                    this.Adjustments.SequenceEqual(other.Adjustments)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.PlanVersion == other.PlanVersion ||
                    this.PlanVersion != null &&
                    this.PlanVersion.Equals(other.PlanVersion)
                ) && 
                (
                    this.DunningPlan == other.DunningPlan ||
                    this.DunningPlan != null &&
                    this.DunningPlan.Equals(other.DunningPlan)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.OrgAmount == other.OrgAmount ||
                    this.OrgAmount != null &&
                    this.OrgAmount.Equals(other.OrgAmount)
                ) && 
                (
                    this.AmountVat == other.AmountVat ||
                    this.AmountVat != null &&
                    this.AmountVat.Equals(other.AmountVat)
                ) && 
                (
                    this.AmountExVat == other.AmountExVat ||
                    this.AmountExVat != null &&
                    this.AmountExVat.Equals(other.AmountExVat)
                ) && 
                (
                    this.SettledAmount == other.SettledAmount ||
                    this.SettledAmount != null &&
                    this.SettledAmount.Equals(other.SettledAmount)
                ) && 
                (
                    this.RefundedAmount == other.RefundedAmount ||
                    this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(other.RefundedAmount)
                ) && 
                (
                    this.PeriodNumber == other.PeriodNumber ||
                    this.PeriodNumber != null &&
                    this.PeriodNumber.Equals(other.PeriodNumber)
                ) && 
                (
                    this.OrderLines == other.OrderLines ||
                    this.OrderLines != null &&
                    this.OrderLines.SequenceEqual(other.OrderLines)
                ) && 
                (
                    this.AdditionalCosts == other.AdditionalCosts ||
                    this.AdditionalCosts != null &&
                    this.AdditionalCosts.SequenceEqual(other.AdditionalCosts)
                ) && 
                (
                    this.CardTransactions == other.CardTransactions ||
                    this.CardTransactions != null &&
                    this.CardTransactions.SequenceEqual(other.CardTransactions)
                ) && 
                (
                    this.ManualTransactions == other.ManualTransactions ||
                    this.ManualTransactions != null &&
                    this.ManualTransactions.SequenceEqual(other.ManualTransactions)
                ) && 
                (
                    this.CreditNotes == other.CreditNotes ||
                    this.CreditNotes != null &&
                    this.CreditNotes.SequenceEqual(other.CreditNotes)
                ) && 
                (
                    this.DunningStart == other.DunningStart ||
                    this.DunningStart != null &&
                    this.DunningStart.Equals(other.DunningStart)
                ) && 
                (
                    this.DunningCount == other.DunningCount ||
                    this.DunningCount != null &&
                    this.DunningCount.Equals(other.DunningCount)
                ) && 
                (
                    this.DunningExpired == other.DunningExpired ||
                    this.DunningExpired != null &&
                    this.DunningExpired.Equals(other.DunningExpired)
                ) && 
                (
                    this.PeriodFrom == other.PeriodFrom ||
                    this.PeriodFrom != null &&
                    this.PeriodFrom.Equals(other.PeriodFrom)
                ) && 
                (
                    this.PeriodTo == other.PeriodTo ||
                    this.PeriodTo != null &&
                    this.PeriodTo.Equals(other.PeriodTo)
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
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Due != null)
                    hash = hash * 59 + this.Due.GetHashCode();
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();
                if (this.Settled != null)
                    hash = hash * 59 + this.Settled.GetHashCode();
                if (this.Cancelled != null)
                    hash = hash * 59 + this.Cancelled.GetHashCode();
                if (this.Credits != null)
                    hash = hash * 59 + this.Credits.GetHashCode();
                if (this.Adjustments != null)
                    hash = hash * 59 + this.Adjustments.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.PlanVersion != null)
                    hash = hash * 59 + this.PlanVersion.GetHashCode();
                if (this.DunningPlan != null)
                    hash = hash * 59 + this.DunningPlan.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                if (this.OrgAmount != null)
                    hash = hash * 59 + this.OrgAmount.GetHashCode();
                if (this.AmountVat != null)
                    hash = hash * 59 + this.AmountVat.GetHashCode();
                if (this.AmountExVat != null)
                    hash = hash * 59 + this.AmountExVat.GetHashCode();
                if (this.SettledAmount != null)
                    hash = hash * 59 + this.SettledAmount.GetHashCode();
                if (this.RefundedAmount != null)
                    hash = hash * 59 + this.RefundedAmount.GetHashCode();
                if (this.PeriodNumber != null)
                    hash = hash * 59 + this.PeriodNumber.GetHashCode();
                if (this.OrderLines != null)
                    hash = hash * 59 + this.OrderLines.GetHashCode();
                if (this.AdditionalCosts != null)
                    hash = hash * 59 + this.AdditionalCosts.GetHashCode();
                if (this.CardTransactions != null)
                    hash = hash * 59 + this.CardTransactions.GetHashCode();
                if (this.ManualTransactions != null)
                    hash = hash * 59 + this.ManualTransactions.GetHashCode();
                if (this.CreditNotes != null)
                    hash = hash * 59 + this.CreditNotes.GetHashCode();
                if (this.DunningStart != null)
                    hash = hash * 59 + this.DunningStart.GetHashCode();
                if (this.DunningCount != null)
                    hash = hash * 59 + this.DunningCount.GetHashCode();
                if (this.DunningExpired != null)
                    hash = hash * 59 + this.DunningExpired.GetHashCode();
                if (this.PeriodFrom != null)
                    hash = hash * 59 + this.PeriodFrom.GetHashCode();
                if (this.PeriodTo != null)
                    hash = hash * 59 + this.PeriodTo.GetHashCode();
                return hash;
            }
        }
    }

}