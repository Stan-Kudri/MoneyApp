using Core.Components.SmartEnum;

namespace MoneyApp.Model.Item.WalletItem
{
    public class AccountModel : NotifyPropertyChanged
    {
        private string _name = string.Empty;
        private TypeWallet _typeWallet = TypeWallet.Unknown;
        private TypeCurrency _currency = TypeCurrency.Unknown;
        private decimal _balance = decimal.Zero;
        private string _description = string.Empty;

        private AccountModel()
        {
        }

        public AccountModel(string name, TypeWallet typeWallet, TypeCurrency currency, decimal balance)
            : this(name, typeWallet, currency, balance, string.Empty)
        {
        }

        public AccountModel(string name, TypeWallet typeWallet, TypeCurrency currency, decimal balance, string description)
        {
            _name = name == string.Empty
                ? throw new ArgumentException("The title has not been announced.", nameof(name))
                : name;

            _typeWallet = typeWallet == TypeWallet.Unknown
                ? throw new ArgumentException("No wallet type selected.", nameof(typeWallet))
                : typeWallet;

            _currency = currency == TypeCurrency.Unknown
                ? throw new ArgumentException("No currency type selected.", nameof(currency))
                : currency;

            _balance = balance;
            _description = description;
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public TypeWallet TypeWallet
        {
            get => _typeWallet;
            set => SetField(ref _typeWallet, value);
        }

        public TypeCurrency TypeCurrency
        {
            get => _currency;
            set => SetField(ref _currency, value);
        }

        public decimal Balance
        {
            get => _balance;
            set => SetField(ref _balance, value);
        }

        public string Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }
    }
}
