using Newtonsoft.Json;

namespace TaxProject.Models.Taxjar
{
    // https://developers.taxjar.com/api/reference/?csharp#post-calculate-sales-tax-for-an-order
    public class NexusAddress
    {
        /// <summary>
        /// Unique identifier of the given nexus address.
        /// Optional.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Two-letter ISO country code for the nexus address.
        /// Required.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Postal code for the nexus address.
        /// Optional.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Two-letter ISO state code for the nexus address.
        /// Required.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// City for the nexus address.
        /// Optional.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Street address for the nexus address.
        /// Optional.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }
    }
}
