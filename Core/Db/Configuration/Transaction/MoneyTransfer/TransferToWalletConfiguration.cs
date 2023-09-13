using Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Db.Configuration.Transaction.MoneyTransfer
{
    public class TransferToWalletConfiguration : ConfigurationBase<TransferToWallet>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<TransferToWallet> builder)
        {
            builder.Property(e => e.Comment).HasMaxLength(128).HasDefaultValue(string.Empty).IsRequired();
            builder.Property(e => e.Date).HasDefaultValue(DateTime.Now).IsRequired();
            builder.Property(e => e.Money).HasDefaultValue(0).IsRequired();
            builder.Property(e => e.ToWalletId).IsRequired();
        }
    }
}
