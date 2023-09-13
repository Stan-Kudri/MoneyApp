using Core.Components.SmartEnum;
using System.Net;
using System.Xml.Linq;

namespace Core.Components.Currency
{
    public class CurrencyExchange : Entity
    {
        private const string DefoultRateByRUB = "1";

        public TypeCurrency TypeFromCurrency { get; set; } = TypeCurrency.Unknown;

        public TypeCurrency TypeToCurrency { get; set; } = TypeCurrency.Unknown;

        public decimal Rate { get; set; }

        private async Task<decimal> GetRate()
        {
            if (TypeToCurrency == null || TypeFromCurrency == null)
            {
                throw new Exception("Type 'to' or 'from' currency cannot be null");
            }

            if (TypeToCurrency == TypeCurrency.Unknown || TypeFromCurrency == TypeCurrency.Unknown)
            {
                throw new Exception("Unknown currency");
            }

            using WebClient client = new();
            var xml = await client.DownloadStringTaskAsync(new Uri("https://www.cbr-xml-daily.ru/daily.xml"));
            XDocument xdoc = XDocument.Parse(xml);

            var el = xdoc.Element("ValCurs").Elements("Valute");

            string? toValueRate = TypeToCurrency == TypeCurrency.RUB ?
                DefoultRateByRUB :
                el.Where(x => x.Attribute("ID").Value == TypeToCurrency.ValuteId).Select(x => x.Element("Value").Value).FirstOrDefault();

            string? fromValueRate = TypeToCurrency == TypeCurrency.RUB ?
                DefoultRateByRUB :
                el.Where(x => x.Attribute("ID").Value == TypeFromCurrency.ValuteId).Select(x => x.Element("Value").Value).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(toValueRate) && !string.IsNullOrWhiteSpace(fromValueRate))
            {
                return Convert.ToDecimal(fromValueRate) / Convert.ToDecimal(toValueRate);
            }

            return 1;
        }
    }
}
