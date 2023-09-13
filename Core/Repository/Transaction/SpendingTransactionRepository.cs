using Core.Components.Transaction;
using Core.Db;

namespace Core.Repository.Transaction
{
    public class SpendingTransactionRepository
    {
        private readonly AppDbContext _db;

        public SpendingTransactionRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(WalletSpendingTransaction spendingTransaction)
        {
            var wallet = _db.Wallet.FirstOrDefault(e => e.Id == spendingTransaction.WalletId);

            if (wallet == null)
            {
                return;
            }

            _db.WalletSpendings.Add(spendingTransaction);
            _db.SaveChanges();
        }

        public void Remove(WalletSpendingTransaction spendingTransaction)
        {
            var transaction = _db.WalletSpendings.FirstOrDefault(e => e.Id == spendingTransaction.Id);

            if (transaction == null)
            {
                return;
            }

            _db.WalletSpendings.Remove(transaction);
            _db.SaveChanges();
        }
    }
}
