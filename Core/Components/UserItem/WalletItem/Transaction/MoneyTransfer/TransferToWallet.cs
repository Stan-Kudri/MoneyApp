using Core.Components.Currency;
using Core.Components.Transaction;

namespace Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer
{
    public class TransferToWallet : WalletTransactionBase
    {
        public Guid ToWalletId { get; set; }

        public CurrencyExchange? CurrencyExchange { get; set; }
    }
}
