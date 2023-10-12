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

        private AccountCashForm() => InitializeComponent();

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

        private void BtnSave_Click(object sender, EventArgs e) => Save();

        protected virtual void Save()
        {
        }

        protected virtual void AccountCash_Load(object sender, EventArgs e)
        {
            itemsBSTypeWallet.DataSource = new SelectableTypeWallet();
            itemsBSCurrency.DataSource = new SelectableCurrencyWallet();
        }

        public virtual Wallet GetWallet() => null;
    }
}
