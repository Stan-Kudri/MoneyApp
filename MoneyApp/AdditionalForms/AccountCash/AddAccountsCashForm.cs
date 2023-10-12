using Core.Components.Message;
using Core.Components.UserItem;
using Core.Db;
using MoneyApp.Model.Item.WalletItem;

namespace MoneyApp.AdditionalForms.AccountCash
{
    public class AddAccountsCashForm : AccountCashForm
    {
        private Guid _userId = Guid.Empty;

        public AddAccountsCashForm(IServiceProvider serviceProvider, IMessageBox messageBox, AppDbContext dbContext)
            : base(serviceProvider, messageBox, dbContext)
        {
        }

        public void Initialize(Guid userId) => _userId = userId;

        protected override void Save()
        {
            if (!IsDataEntered(out var message))
            {
                _messageBox.ShowWarning(message);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void AccountCash_Load(object sender, EventArgs e)
        {
            itemsBSTypeWallet.DataSource = new SelectableTypeWallet();
            itemsBSCurrency.DataSource = new SelectableCurrencyWallet();
        }

        public override Wallet GetWallet()
        {
            var currency = _dbContext.Currency.FirstOrDefault(e => e.Type == SelectedTypeCurrency);

            if (currency == null)
            {
                throw new Exception("Type of currency unknown");
            }

            if (!decimal.TryParse(tbBalance.Text, out var balance))
            {
                throw new Exception("Invalid balance format.");
            }

            if (_userId == Guid.Empty)
            {
                throw new Exception("The ID is set incorrectly.");
            }

            var accountModel = new AccountModel(tbName.Text, SelectedTypeWallet, SelectedTypeCurrency, balance, tbDescription.Text);

            return new Wallet(accountModel.Name, SelectedTypeWallet, _userId, accountModel.Balance, currency, accountModel.Description, currency.Id);
        }
    }
}
