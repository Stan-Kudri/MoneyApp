using Core.Components.Message;
using Core.Db;
using Core.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using MoneyApp.AdditionalForms.AccountCash;
using System.Text;

namespace MoneyApp
{
    public partial class MoneyAppForm : MaterialForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _appDbContext;
        private readonly WalletService _walletService;
        private readonly IMessageBox _messageBox;

        private Guid _idUser;

        public MoneyAppForm(IServiceProvider serviceProvider, AppDbContext appDbContext, WalletService walletService, IMessageBox messageBox)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _appDbContext = appDbContext;
            _walletService = walletService;
            _messageBox = messageBox;
        }

        public void Initialize(Guid? userId)
        {
            var item = _appDbContext.Users.FirstOrDefault(e => e.Id == userId)?.Id;
            _idUser = item != null ? (Guid)item : throw new ArgumentException("There is no user with this ID.");
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            using var formAddAccountCash = _serviceProvider.GetRequiredService<AddAccountsCashForm>();
            formAddAccountCash.Initialize(_idUser);

            if (formAddAccountCash.ShowDialog() == DialogResult.OK)
            {
                _walletService.Add(formAddAccountCash.GetWallet());
            }
            UppDateAccountCash();
        }

        private void BtnEditItemAccountCash_Click(object sender, EventArgs e)
        {
            var id = GetSelectedIDItem();

            if (id == null)
            {
                _messageBox.ShowError("Error reading element.");
            }

            var item = _walletService.GetWallet(id);
            var editItemForm = _serviceProvider.GetRequiredService<EditAccountCashForm>();
            editItemForm.Initialize(item);

            if (editItemForm.ShowDialog() == DialogResult.Yes)
            {
                _walletService.Edit(editItemForm.GetWallet());
            }

            UppDateAccountCash();
        }

        private void BtnDeliteItem_Click(object sender, EventArgs e)
        {
            var idWallet = GetSelectedIDItem();

            DialogResult = MessageBox.Show("Remove item account cash?", "Information", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.No)
            {
                return;
            }

            _walletService.Remove(idWallet);
            UppDateAccountCash();
        }

        private void MoneyAppForm_Load(object sender, EventArgs e)
        {
            LoadWalletItems();
            LoadDebitItems();
        }

        private void LoadWalletItems()
        {
            listBoxAccounts.Clear();
            foreach (var element in _walletService.GetWalletList())
            {
                string line = new StringBuilder($"{element.Name} - {element.Money} {element.Currency}").ToString();
                var item = new MaterialListBoxItem(line) { Tag = element.Id };
                listBoxAccounts.AddItem(item);
            }
        }

        private void LoadDebitItems()
        {
            listBoxDebit.Clear();
            foreach (var element in _walletService.GetDebitList())
            {
                string line = new StringBuilder($"{element.Name} - {element.Money} {element.Currency}").ToString();
                var item = new MaterialListBoxItem(line) { Tag = element.Id };
                listBoxDebit.AddItem(item);
            }
        }

        private void UppDateAccountCash()
        {
            LoadWalletItems();
            LoadDebitItems();
        }

        private Guid? GetSelectedIDItem()
        {
            var tag = string.Empty;
            switch (tcAccountCash.SelectedIndex)
            {
                //0 - Tab index for listBoxAccounts.
                case 0:
                    {
                        tag = listBoxAccounts.SelectedItem.Tag.ToString();
                    }
                    break;
                //1 - Tab index for listBoxDebit.
                case 1:
                    {
                        tag = listBoxDebit.SelectedItem.Tag.ToString();
                    }
                    break;
            }

            if (!Guid.TryParse(tag, out Guid id))
            {
                return null;
            }

            return id;
        }
    }
}
