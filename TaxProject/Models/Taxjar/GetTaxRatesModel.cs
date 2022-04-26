using Newtonsoft.Json;

namespace TaxProject.Models.Taxjar
{
    // https://developers.taxjar.com/api/reference/#get-show-tax-rates-for-a-location
    public class GetTaxRatesModel
    {
        /// <summary>
        /// Postal code for given location (5-Digit ZIP or ZIP+4).
        /// Required.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Two-letter ISO state code for given location.
        /// Optional.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// City for given location.
        /// Optional.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Street address for given location.
        /// Optional.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }
    }
}
