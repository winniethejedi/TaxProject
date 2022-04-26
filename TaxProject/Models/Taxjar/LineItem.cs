using Newtonsoft.Json;

namespace TaxProject.Models.Taxjar
{
    // https://developers.taxjar.com/api/reference/?csharp#post-calculate-sales-tax-for-an-order
    public class LineItem
    {
        /// <summary>
        /// Unique identifier of the given line item.
        /// Optional.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Quantity for the item.
        /// Optional.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Product tax code for the item. If omitted, the item will remain fully taxable.
        /// Optional.
        /// </summary>
        [JsonProperty("product_tax_code")]
        public string ProductTaxCode { get; set; }

        /// <summary>
        /// Unit price for the item.
        /// Optional.
        /// </summary>
        [JsonProperty("unit_price")]
        public float UnitPrice { get; set; }

        /// <summary>
        /// Total discount (non-unit) for the item.
        /// Optional.
        /// </summary>
        [JsonProperty("discount")]
        public float Discount { get; set; }
    }
}
