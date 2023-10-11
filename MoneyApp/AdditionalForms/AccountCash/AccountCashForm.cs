using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Components.UserItem;
using Core.Db;
using MaterialSkin.Controls;
using MoneyApp.Model.Item.WalletItem;

namespace MoneyApp.AdditionalForms.AccountCash
{
    public partial class AccountCashForm : MaterialForm
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly AppDbContext _dbContext;
        protected readonly IMessageBox _messageBox;

        protected Guid _userId = Guid.Empty;

        private AccountCashForm()
        {
        }

        public AccountCashForm(IServiceProvider serviceProvider, IMessageBox messageBox, AppDbContext dbContext)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _messageBox = messageBox;
            _dbContext = dbContext;
        }

        protected TypeWallet SelectedTypeWallet =>
            cbTypeWallet.SelectedValue != null ? (TypeWallet)cbTypeWallet.SelectedValue : throw new Exception("Wrong combo box format");

        protected TypeCurrency SelectedTypeCurrency =>
            cbCurrency.SelectedValue != null ? (TypeCurrency)cbCurrency.SelectedValue : throw new Exception("Wrong combo box format");

        protected void TbBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        protected bool IsDataEntered(out string message)
        {
            if (tbName.Text.Length == decimal.Zero)
            {
                message = "Please enter a name.";
                return false;
            }
            if (cbTypeWallet.Text.Length <= 0)
            {
                message = "Select your wallet type.";
                return false;
            }
            if (cbCurrency.Text.Length <= 0)
            {
                message = "Select your currency type.";
                return false;
            }
            if (tbBalance.Text.Length == decimal.Zero)
            {
                message = "Please enter balance.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            if (!IsDataEntered(out var message))
            {
                _messageBox.ShowWarning(message);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void AccountCash_Load(object sender, EventArgs e)
        {
            itemsBSTypeWallet.DataSource = new SelectableTypeWallet();
            itemsBSCurrency.DataSource = new SelectableCurrencyWallet();
        }

        public virtual Wallet GetWallet()
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
