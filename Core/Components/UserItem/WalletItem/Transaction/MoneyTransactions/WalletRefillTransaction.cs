using Core.Components.Transaction.Category;

namespace Core.Components.Transaction
{
    public class WalletRefillTransaction : WalletTransactionBase
    {
        public List<RefillCategory>? RefillCategories { get; set; }
    }
}
