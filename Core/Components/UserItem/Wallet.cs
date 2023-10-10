using Core.Components.SmartEnum;
using Core.Components.Transaction;
using Core.Components.UserItem.WalletItem.Transaction.MoneyTransfer;

namespace Core.Components.UserItem
{
    public class Wallet : Entity
    {

        public Wallet(string name, TypeWallet type, Guid userId, decimal money, Currency currency, string description, Guid currencyId)
        {
            Name = name;
            TypeWallet = type;
            UserId = userId;
            CurrencyId = currencyId;
            Money = money;
            Currency = currency;
            Description = description;
        }

        public Wallet(string name, TypeWallet type, Guid userId, decimal money, Currency currency, string description, Guid currencyId, Guid id)
            : this(name, type, userId, money, currency, description, currencyId)
        {
            Id = id;
        }

        //EF
        public Wallet()
            : this(string.Empty, TypeWallet.Unknown, Guid.NewGuid(), 0, new Currency(), string.Empty, Guid.NewGuid())
        {
        }

        public string Name { get; set; } = string.Empty;

        public TypeWallet TypeWallet { get; set; } = TypeWallet.Unknown;

        public Guid UserId { get; set; }

        public Guid CurrencyId { get; set; }

        public decimal Money { get; set; }

        public Currency? Currency { get; set; }

        public string Description { get; set; } = string.Empty;

        public List<WalletRefillTransaction>? RefillTransactions { get; set; }

        public List<WalletSpendingTransaction>? SpendingTransactions { get; set; }

        public List<TransferToWallet>? TransferToWallets { get; set; }

        public override bool Equals(object? obj) => Equals(obj as Wallet);

        public bool Equals(Wallet? other)
        {
            if (other == null)
            {
                return false;
            }

            return Id == other.Id
                && Name == other.Name
                && TypeWallet == other.TypeWallet
                && Money == other.Money
                && Currency == other.Currency
                && Description == other.Description
                && TransferToWallets == other.TransferToWallets
                && RefillTransactions == other.RefillTransactions
                && SpendingTransactions == other.SpendingTransactions;
        }

        public override int GetHashCode()
            => HashCode.Combine(Id, Name, TypeWallet, Currency, Money, Description);
    }
}
