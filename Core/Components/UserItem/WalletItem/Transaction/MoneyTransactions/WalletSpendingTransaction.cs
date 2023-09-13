using Core.Components.Transaction.Category;

namespace Core.Components.Transaction
{
    public class WalletSpendingTransaction : WalletTransactionBase
    {
        public List<SpendingCategory>? SpendingCategories { get; set; }
    }
}
