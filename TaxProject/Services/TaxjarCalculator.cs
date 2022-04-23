using Microsoft.Extensions.Options;
using RestSharp;
using TaxProject.Configuration;

namespace TaxProject.Services
{
    internal class TaxjarCalculator : ITaxCalculator
    {
        private readonly TaxjarConfiguration _taxjarConfiguration;

        public TaxjarCalculator(IOptions<TaxjarConfiguration> taxjarConfigurationOptions)
        {
            _taxjarConfiguration = taxjarConfigurationOptions?.Value ?? throw new ArgumentNullException(nameof(taxjarConfigurationOptions));
        }

        public TaxjarCalculator()
        {
            var client = new RestClient();

            //client
        }
    }
}
