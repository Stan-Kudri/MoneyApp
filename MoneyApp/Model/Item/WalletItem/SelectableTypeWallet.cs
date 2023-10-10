using Core.Components.SmartEnum;
using System.Collections.ObjectModel;

namespace MoneyApp.Model.Item.WalletItem
{
    public class SelectableTypeWallet : NotifyPropertyChanged
    {
        private TypeWallet _type = TypeWallet.Card;

        public SelectableTypeWallet()
        {
        }

        public SelectableTypeWallet(TypeWallet type) => Type = type;

        public ObservableCollection<TypeWallet> Items { get; set; } =
            new ObservableCollection<TypeWallet>(TypeWallet.List.Where(x => x != TypeWallet.Unknown));

        public TypeWallet Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }
    }
}
