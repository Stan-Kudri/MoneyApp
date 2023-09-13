using Core.Components.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.TransactionConfig
{
    public class SpendingTransactionConfiguration : ConfigurationBase<WalletSpendingTransaction>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<WalletSpendingTransaction> builder)
        {
            builder.Property(e => e.Comment).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Money).HasDefaultValue(0).IsRequired();
            builder.Property(e => e.Date).HasDefaultValue(DateTime.Today).IsRequired();
            builder.HasMany(e => e.SpendingCategories).WithOne().HasForeignKey(e => e.Id);
        }
    }
}
