using Ardalis.SmartEnum;

namespace Core.Components.SmartEnum
{
    public class TypeCurrency : SmartEnum<TypeCurrency>
    {
        public readonly static TypeCurrency Unknown = new TypeCurrency("Unknown", 0, null);
        public readonly static TypeCurrency USD = new TypeCurrency("USD", 1, "R01235");
        public readonly static TypeCurrency EUR = new TypeCurrency("EUR", 2, "R01239");
        public readonly static TypeCurrency BLR = new TypeCurrency("BLR", 3, "R01090B");
        public readonly static TypeCurrency RUB = new TypeCurrency("RUB", 4, string.Empty);

        public TypeCurrency(string name, int value, string? valuteID) : base(name, value)
        {
        }

        //Valute ID in https://www.cbr-xml-daily.ru/daily.xml
        public string? ValuteId { get; private set; }
    }
}
