using Core.Components.UserItem;
using Core.Db;

namespace Core.Repository
{
    public class WalletRepository
    {
        private readonly AppDbContext _db;

        public WalletRepository(AppDbContext dbContext) => _db = dbContext;

        public void Add(Wallet wallet)
        {
            var user = _db.Users.FirstOrDefault(e => e.Id == wallet.UserId);

            if (wallet == null || user == null)
            {
                return;
            }

            _db.Wallet.Add(wallet);
            _db.SaveChanges();
        }

        public void Remove(Guid idWallet)
        {
            var wallet = _db.Wallet.FirstOrDefault(e => e.Id == idWallet);

            if (wallet == null)
            {
                return;
            }

            _db.Wallet.Remove(wallet);
            _db.SaveChanges();
        }
    }
}
