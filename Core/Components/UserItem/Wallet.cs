using Core.Components.SmartEnum;
using Core.Components.Transaction;
using Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer;

namespace Core.Components.UserItem
{
    public class Wallet : Entity
    {
        public Wallet(string name, TypeWallet type, Guid userId, Guid currencyId, decimal money, Currency currency)
        {
            Name = name;
            TypeWallet = type;
            UserId = userId;
            CurrencyId = currencyId;
            Money = money;
            Currency = currency;
        }

        //EF
        public Wallet()
            : this(string.Empty, TypeWallet.Unknown, Guid.NewGuid(), Guid.NewGuid(), 0, new Currency())
        {
        }

        public string Name { get; set; } = string.Empty;

        public TypeWallet TypeWallet { get; set; } = TypeWallet.Unknown;

        public Guid UserId { get; set; }

        public Guid CurrencyId { get; set; }

        public decimal Money { get; set; }

        public Currency? Currency { get; set; }

        public List<WalletRefillTransaction>? RefillTransactions { get; set; }

        public List<WalletSpendingTransaction>? SpendingTransactions { get; set; }

        public List<TransferToWallet>? TransferToWallets { get; set; }
    }
}
