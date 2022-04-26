using Microsoft.Extensions.Options;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.Configuration;
using TaxProject.Models;
using TaxProject.Models.Taxjar;

namespace TaxProject.Clients
{
    internal class TaxJarClient : ITaxJarClient
    {
        private readonly RestClient _restClient;
        private readonly TaxjarConfiguration _taxjarConfiguration;

        public TaxJarClient(IOptions<TaxjarConfiguration> taxjarConfigurationOptions)
        {
            _restClient = new RestClient("https://api.taxjar.com/v2");
            _taxjarConfiguration = taxjarConfigurationOptions?.Value ?? throw new ArgumentNullException(nameof(taxjarConfigurationOptions));
        }

        public async Task<float> GetTaxRateAsync(Address address)
        {
            ArgumentNullException.ThrowIfNull(address);

            if (string.IsNullOrWhiteSpace(address.Zip))
            {
                throw new ArgumentException($"{nameof(address.Zip)} cannot be null or white space.", nameof(address));
            }

            if (!string.IsNullOrWhiteSpace(address.Country)
                && address.Country.Length != 2)
            {
                throw new ArgumentException($"{nameof(address.Country)} must be a two-letter ISO country code.", nameof(address));
            }

            if (!string.IsNullOrWhiteSpace(address.State)
                && address.State.Length != 2)
            {
                throw new ArgumentException($"{nameof(address.State)} must be a two-letter ISO state code.", nameof(address));
            }

            var restRequest = GetRestRequest("rates", Method.Get);
            restRequest.AddParameter("zip", address.Zip);

            if (!string.IsNullOrWhiteSpace(address.Country))
            {
                restRequest.AddParameter("country", address.Country);
            }

            if (!string.IsNullOrWhiteSpace(address.State))
            {
                restRequest.AddParameter("state", address.State);
            }

            if (!string.IsNullOrWhiteSpace(address.City))
            {
                restRequest.AddParameter("city", address.City);
            }

            if (!string.IsNullOrWhiteSpace(address.Street))
            {
                restRequest.AddParameter("street", address.Street);
            }

            var response = await _restClient.PostAsync<UnitedStatesRatesModel>(restRequest);

            if (response == null)
            {
                throw new Exception("Rate not found.");
            }

            return response.CombinedRate;
        }

        private RestRequest GetRestRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method);
            request.AddHeader("Authorization", $"Bearer {_taxjarConfiguration.ApiKey}");
            return request;
        }
    }
}
