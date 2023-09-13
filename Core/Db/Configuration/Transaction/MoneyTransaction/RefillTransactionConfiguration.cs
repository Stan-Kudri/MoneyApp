using Core.Components.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.TransactionConfig
{
    public class RefillTransactionConfiguration : ConfigurationBase<WalletRefillTransaction>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<WalletRefillTransaction> builder)
        {
            builder.Property(e => e.Comment).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Money).HasDefaultValue(0).IsRequired();
            builder.Property(e => e.Date).HasDefaultValue(DateTime.Today).IsRequired();
            builder.HasMany(e => e.RefillCategories).WithOne().HasForeignKey(e => e.Id);
        }
    }
}
