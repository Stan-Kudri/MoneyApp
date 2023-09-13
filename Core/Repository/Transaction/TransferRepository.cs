using Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer;
using Core.Db;

namespace Core.Repository.Transaction
{
    public class TransferRepository
    {
        private readonly AppDbContext _db;

        public TransferRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(TransferToWallet transfer)
        {
            var walletTransferMoney = _db.Wallet.FirstOrDefault(e => e.Id == transfer.WalletId);
            var walletReceiveMoney = _db.Wallet.FirstOrDefault(e => e.Id == transfer.ToWalletId);

            if (walletTransferMoney == null || walletReceiveMoney == null)
            {
                return;
            }

            _db.TransferToWallets.Add(transfer);
            _db.SaveChanges();
            //_db.TransferToWallets.Add(walletReceiveMoney);
        }

        public void Remove(TransferToWallet transfer)
        {
            var transaction = _db.TransferToWallets.FirstOrDefault(e => e.Id == transfer.Id);

            if (transaction == null)
            {
                return;
            }

            _db.TransferToWallets.Remove(transaction);
            _db.SaveChanges();
        }
    }
}
