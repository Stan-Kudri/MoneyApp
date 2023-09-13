using Core.Components;
using Core.Components.Transaction;
using Core.Components.Transaction.Category;
using Core.Components.UserItem;
using Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer;
using Microsoft.EntityFrameworkCore;

namespace Core.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Wallet> Wallet { get; set; } = null!;

        public DbSet<Currency> Currency { get; set; } = null!;

        public DbSet<WalletRefillTransaction> WalletRefills { get; set; } = null!;

        public DbSet<WalletSpendingTransaction> WalletSpendings { get; set; } = null!;

        public DbSet<RefillCategory> Refills { get; set; } = null!;

        public DbSet<SpendingCategory> Spendings { get; set; } = null!;

        public DbSet<TransferToWallet> TransferToWallets { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
