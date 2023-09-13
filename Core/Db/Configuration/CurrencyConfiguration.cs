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
        }
    }
}
