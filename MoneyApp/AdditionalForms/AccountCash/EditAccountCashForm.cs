using Core.Components.Message;
using Core.Components.UserItem;
using Core.Db;
using MoneyApp.Model.Item.WalletItem;

namespace MoneyApp.AdditionalForms.AccountCash
{
    public class EditAccountCashForm : AccountCashForm
    {
        public EditAccountCashForm(IServiceProvider serviceProvider, IMessageBox messageBox, AppDbContext dbContext)
            : base(serviceProvider, messageBox, dbContext)
        {
        }

        public Wallet EditItem { get; private set; }

        public void Initialize(Wallet item)
        {
            EditItem = item;
            _userId = EditItem.UserId;
        }

        protected override void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataEntered(out var message))
            {
                _messageBox.ShowWarning(message);
                return;
            }

            if (HasChanges())
            {
                DialogResult = MessageBox.Show("Save edit item account cash?", "Information", MessageBoxButtons.YesNo);
            }
            else
            {
                _messageBox.ShowInfo("No changed item account cash.");
                DialogResult = DialogResult.No;
            }

            Close();
        }

        protected override void AccountCash_Load(object sender, EventArgs e)
        {

            itemsBSTypeWallet.DataSource = new SelectableTypeWallet();
            itemsBSCurrency.DataSource = new SelectableCurrencyWallet();
            SetupDefoultValue();
        }

        public void SetupDefoultValue()
        {
            tbBalance.Text = EditItem.Money.ToString();
            tbName.Text = EditItem.Name;
            tbDescription.Text = EditItem.Description;
            cbCurrency.SelectedItem = EditItem.Currency?.Type;
            cbTypeWallet.SelectedItem = EditItem.TypeWallet;
        }

        public bool HasChanges() => !EditItem.Equals(GetWallet());

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

            var accountModel = new AccountModel(tbName.Text, SelectedTypeWallet, SelectedTypeCurrency, balance, tbDescription.Text);

            return new Wallet(accountModel.Name, SelectedTypeWallet, _userId, accountModel.Balance, currency, accountModel.Description, currency.Id, EditItem.Id);
        }
    }
}
