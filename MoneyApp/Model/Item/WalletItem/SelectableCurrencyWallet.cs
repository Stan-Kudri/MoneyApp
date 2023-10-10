using Core.Components.SmartEnum;
using System.Collections.ObjectModel;

namespace MoneyApp.Model.Item.WalletItem
{
    public class SelectableCurrencyWallet : NotifyPropertyChanged
    {
        private TypeCurrency _type = TypeCurrency.RUB;

        public SelectableCurrencyWallet()
        {
        }

        public SelectableCurrencyWallet(TypeCurrency type) => Type = type;

        public ObservableCollection<TypeCurrency> Items { get; set; } =
            new ObservableCollection<TypeCurrency>(TypeCurrency.List.Where(x => x != TypeCurrency.Unknown));

        public TypeCurrency Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }
    }
}
