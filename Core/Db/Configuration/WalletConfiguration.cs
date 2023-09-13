using Core.Components.UserItem;
using Core.Db.Extension;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration
{
    public class WalletConfiguration : ConfigurationBase<Wallet>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Wallet> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(48).IsRequired();
            builder.Property(e => e.Money).HasDefaultValue(0).IsRequired();
            builder.Property(e => e.TypeWallet).SmartEnumConversion();
            builder
                .HasOne(e => e.Currency)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId)
                .IsRequired();
            builder.
                HasMany(e => e.SpendingTransactions).
                WithOne().
                HasForeignKey(e => e.WalletId);
            builder.
                HasMany(e => e.RefillTransactions).
                WithOne().
                HasForeignKey(e => e.WalletId);
            builder.
                HasMany(e => e.TransferToWallets).
                WithOne().
                HasForeignKey(e => e.WalletId);

        }
    }
}
