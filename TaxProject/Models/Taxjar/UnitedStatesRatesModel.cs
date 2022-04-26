using Newtonsoft.Json;

namespace TaxProject.Models.Taxjar
{
    // https://developers.taxjar.com/api/reference/#get-show-tax-rates-for-a-location
    public class UnitedStatesRatesModel
    {
        /// <summary>
        /// Postal code for given location.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Country for given location if SST state.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Country sales tax rate for given location if SST state.
        /// </summary>
        [JsonProperty("country_rate")]
        public float CountryRate { get; set; }

        /// <summary>
        /// Postal abbreviated state name for given location.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// State sales tax rate for given location.
        /// </summary>
        [JsonProperty("state_rate")]
        public float StateRate { get; set; }

        /// <summary>
        /// County name for given location.
        /// </summary>
        [JsonProperty("county")]
        public string County { get; set; }

        /// <summary>
        /// County sales tax rate for given location.
        /// </summary>
        [JsonProperty("county_rate")]
        public float CountyRate { get; set; }

        /// <summary>
        /// City name for given location.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// City sales tax rate for given location.
        /// </summary>
        [JsonProperty("city_rate")]
        public float CityRate { get; set; }

        /// <summary>
        /// Aggregate rate for all city and county sales tax districts effective at the location.
        /// </summary>
        [JsonProperty("combined_district_rate")]
        public float CombinedDistrictRate { get; set; }

        /// <summary>
        /// Overall sales tax rate which includes state, county, city and district tax. This rate should be used to determine how much sales tax to collect for an order.
        /// </summary>
        [JsonProperty("combined_rate")]
        public float CombinedRate { get; set; }

        /// <summary>
        /// Freight taxability for given location.
        /// </summary>
        [JsonProperty("freight_taxable")]
        public bool FreightTaxable { get; set; }
    }
}
