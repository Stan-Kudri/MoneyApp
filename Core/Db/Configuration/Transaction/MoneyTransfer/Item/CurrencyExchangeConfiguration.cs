using Core.Components.Currency;
using Core.Db.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.Transaction.MoneyTransfer.Item
{
    public class CurrencyExchangeConfiguration : ConfigurationBase<CurrencyExchange>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<CurrencyExchange> builder)
        {
            builder.Property(e => e.TypeFromCurrency).SmartEnumConversion();
            builder.Property(e => e.TypeToCurrency).SmartEnumConversion();
            builder.Property(e => e.Rate).HasDefaultValue(1).IsRequired();
        }
    }
}
