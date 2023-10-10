using Core.Components.SmartEnum;
using Core.Components.UserItem;
using Core.Db.Extension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration
{
    public class CurrencyConfiguration : ConfigurationBase<Currency>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(e => e.Type).SmartEnumConversion();

            var list = new List<Currency>();
            foreach (var item in TypeCurrency.List)
            {
                if (item != TypeCurrency.Unknown)
                {
                    list.Add(new Currency() { Type = item, Id = Guid.NewGuid() });
                }
            }
            builder.HasData(list);
        }
    }
}
