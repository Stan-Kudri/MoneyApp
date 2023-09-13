using Core.Components.Transaction;
using Core.Db;

namespace Core.Repository.Transaction
{
    public class RefillTransactionRepository
    {
        private readonly AppDbContext _db;

        public RefillTransactionRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(WalletRefillTransaction refillTransaction)
        {
            var wallet = _db.Wallet.FirstOrDefault(e => e.Id == refillTransaction.WalletId);

            if (wallet == null)
            {
                return;
            }

            _db.WalletRefills.Add(refillTransaction);
            _db.SaveChanges();
        }

        public void Remove(WalletRefillTransaction refillTransaction)
        {
            var transaction = _db.WalletRefills.FirstOrDefault(e => e.Id == refillTransaction.Id);

            if (transaction == null)
            {
                return;
            }

            _db.WalletRefills.Remove(transaction);
            _db.SaveChanges();
        }
    }
}
