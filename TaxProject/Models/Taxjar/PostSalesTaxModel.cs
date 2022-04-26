using Newtonsoft.Json;

namespace TaxProject.Models.Taxjar
{
    // https://developers.taxjar.com/api/reference/?csharp#post-calculate-sales-tax-for-an-order
    public class PostSalesTaxModel
    {
        // Either an address on file, `nexus_addresses` parameter, or `from_` parameters are required to perform tax calculations.

        /// <summary>
        /// Two-letter ISO country code of the country where the order shipped from.
        /// Optional.
        /// </summary>
        [JsonProperty("from_country")]
        public string FromCountry { get; set; }

        /// <summary>
        /// Postal code where the order shipped from (5-Digit ZIP or ZIP+4).
        /// Optional
        /// </summary>
        [JsonProperty("from_zip")]
        public string FromZip { get; set; }

        /// <summary>
        /// Two-letter ISO state code where the order shipped from.
        /// Optional.
        /// </summary>
        [JsonProperty("from_state")]
        public string FromState { get; set; }

        /// <summary>
        /// City where the order shipped from.
        /// Optional.
        /// </summary>
        [JsonProperty("from_city")]
        public string FromCity { get; set; }

        /// <summary>
        /// Street address where the order shipped from.
        /// Optional.
        /// </summary>
        [JsonProperty("from_street")]
        public string FromStreet { get; set; }

        /// <summary>
        /// Two-letter ISO country code of the country where the order shipped to.
        /// Required.
        /// </summary>
        [JsonProperty("to_country")]
        public string ToCountry { get; set; }

        /// <summary>
        /// Postal code where the order shipped to (5-Digit ZIP or ZIP+4).
        /// If `to_country` is 'US', `to_zip` is required.
        /// </summary>
        [JsonProperty("to_zip")]
        public string ToZip { get; set; }

        /// <summary>
        /// Two-letter ISO state code where the order shipped to.
        /// If `to_country` is 'US' or 'CA', `to_state` is required.
        /// </summary>
        [JsonProperty("to_state")]
        public string ToState { get; set; }

        /// <summary>
        /// City where the order shipped to.
        /// Optional.
        /// </summary>
        [JsonProperty("to_city")]
        public string ToCity { get; set; }

        /// <summary>
        /// Street address where the order shipped to.
        /// Optional.
        /// </summary>
        [JsonProperty("to_street")]
        public string ToStreet { get; set; }

        /// <summary>
        /// Total amount of the order, excluding shipping.
        /// Either `amount` or `line_items` parameters are required to perform tax calculations.
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// Total amount of shipping for the order.
        /// Required.
        /// </summary>
        [JsonProperty("shipping")]
        public float Shipping { get; set; }

        /// <summary>
        /// Unique identifier of the given customer for exemptions.
        /// Optional.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Type of exemption for the order: wholesale, government, marketplace, other, or non_exempt.
        /// Optional.
        /// </summary>
        [JsonProperty("exemption_type")]
        public string ExemptionType { get; set; }

        /// <summary>
        /// Either an address on file, `nexus_addresses` parameter, or `from_` parameters are required to perform tax calculations.
        /// </summary>
        [JsonProperty("nexus_addresses")]
        public List<NexusAddress> NexusAddresses { get; set; }

        /// <summary>
        /// Either `amount` or `line_items` parameters are required to perform tax calculations.
        /// </summary>
        [JsonProperty("line_items")]
        public List<NexusAddress> LineItems { get; set; }
    }
}
