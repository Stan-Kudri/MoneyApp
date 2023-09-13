using Core.Components.Transaction.Category;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.TransactionConfig
{
    public class RefillCategoryConfiguration : ConfigurationBase<RefillCategory>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<RefillCategory> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(64).IsRequired();
        }
    }
}
