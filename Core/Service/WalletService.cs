using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Components.UserItem;
using Core.Db;

namespace Core.Service
{
    public class WalletService
    {
        private readonly AppDbContext _db;
        private readonly IMessageBox _messageBox;

        public WalletService(AppDbContext appDbContext, IMessageBox messageBox)
        {
            _db = appDbContext;
            _messageBox = messageBox;
        }

        public void Add(Wallet wallet)
        {
            if (wallet != null)
            {
                _db.Wallet.Add(wallet);
                _db.SaveChanges();
            }
        }

        public void Edit(Wallet wallet)
        {
            if (wallet == null)
            {
                throw new ArgumentNullException("The format of the transmitted data is incorrect.", nameof(wallet));
            }

            var item = _db.Wallet.FirstOrDefault(e => e.Id == wallet.Id) ?? throw new InvalidOperationException("Interaction element not found.");

            item.Name = wallet.Name;
            item.TypeWallet = wallet.TypeWallet;
            item.Currency = wallet.Currency;
            item.Money = wallet.Money;
            item.Description = wallet.Description;

            _db.SaveChanges();
        }

        public void Remove(Guid? idWallet)
        {
            var item = _db.Wallet.FirstOrDefault(e => e.Id == idWallet) ?? throw new InvalidOperationException("Interaction element not found.");
            _db.Remove(item);
            _db.SaveChanges();
        }

        public List<Wallet>? GetWalletList()
        {
            var item = _db.Wallet.Where(e => e.TypeWallet == TypeWallet.Cash || e.TypeWallet == TypeWallet.Card).Select(e => e);

            return item.Count() == decimal.Zero ? new List<Wallet>() : item.ToList();
        }

        public List<Wallet>? GetDebitList()
        {
            var item = _db.Wallet.Where(e => e.TypeWallet == TypeWallet.Debit).Select(e => e);

            return item.Count() == decimal.Zero ? new List<Wallet>() : item.ToList();
        }

        public Wallet GetWallet(Guid? id)
        {
            var item = _db.Wallet.FirstOrDefault(e => e.Id == id);
            if (item == null)
            {
                throw new Exception("There is no element with this ID.");
            }

            return item;
        }
    }
}
