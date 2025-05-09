using Promitor.Core.Contracts;
using Promitor.Core.Contracts.ResourceTypes;
using Promitor.Core.Scraping.Configuration.Model.Metrics;

namespace Promitor.Core.Scraping.ResourceTypes
{
    internal class CognitiveServicesAccountScraper : AzureMonitorScraper<CognitiveServicesAccountResourceDefinition>
    {
        private const string ResourceUriTemplate = "subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.CognitiveServices/accounts/{2}";

        public CognitiveServicesAccountScraper(ScraperConfiguration scraperConfiguration)
            : base(scraperConfiguration)
        {
        }

        protected override string BuildResourceUri(string subscriptionId, ScrapeDefinition<IAzureResourceDefinition> scrapeDefinition, CognitiveServicesAccountResourceDefinition resource)
        {
            return string.Format(ResourceUriTemplate, subscriptionId, scrapeDefinition.ResourceGroupName, resource.CognitiveServicesAccountName);
        }
    }
}
