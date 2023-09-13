using Core.Components.Transaction.Category;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.TransactionConfig
{
    public class SpendingCategoryConfiguration : ConfigurationBase<SpendingCategory>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<SpendingCategory> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(64).IsRequired();
        }
    }
}
