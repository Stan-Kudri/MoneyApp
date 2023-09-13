using Ardalis.SmartEnum;

namespace Core.Components.SmartEnum
{
    public class TypeWallet : SmartEnum<TypeWallet>
    {
        public static readonly TypeWallet Unknown = new TypeWallet("Unknown", 0);
        public static readonly TypeWallet Cash = new TypeWallet("Cash", 1);
        public static readonly TypeWallet Card = new TypeWallet("Card", 2);

        public TypeWallet(string name, int value) : base(name, value)
        {
        }
    }
}
