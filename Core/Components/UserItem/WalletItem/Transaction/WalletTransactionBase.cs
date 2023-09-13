namespace Core.Components.Transaction
{
    public class WalletTransactionBase : Entity
    {
        protected WalletTransactionBase()
        {
        }

        public Guid WalletId { get; set; }

        public decimal Money { get; set; }

        public string Comment { get; set; } = string.Empty;

        public DateTime Date { get; set; }
    }
}
