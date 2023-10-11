using Core.Components;
using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Db;
using Core.Service;
using MaterialSkin.Controls;
using MoneyApp.Model.UserItem;

namespace MoneyApp.AdditionalForms.Account
{
    public partial class AccountLoginForm : MaterialForm
    {
        protected virtual ActionsWithAccount ActionsWithAccount { get; }

        protected readonly IMessageBox _messageBox;
        protected readonly AppDbContext _dbContext;
        protected readonly UserService _userService;
        protected readonly IServiceProvider _serviceProvider;

        private AccountLoginForm()
        {
        }

        public AccountLoginForm(
            IServiceProvider serviceProvider,
            IMessageBox messageBox,
            AppDbContext appDbContext,
            UserService userService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _messageBox = messageBox;
            _dbContext = appDbContext;
            _userService = userService;
            Shown += AccountLogin_Shown;
        }

        public Guid? UserID { get; private set; } = Guid.Empty;

        private void AccountLogin_Shown(object? sender, EventArgs e)
        {
            if (!ActionsWithAccount.IsLogin)
            {
                throw new ArgumentException("Invalid action passed.");
            }

            btnAction.Text = ActionsWithAccount.Name;
        }

        protected void BtnActionUserID_Click(object sender, EventArgs e)
        {
            var user = new UserModel(tbLogin.Text, tbPassword.Text).ToUser();

            if (!ActionClick(user, out string message))
            {
                _messageBox.ShowWarning(message);
                return;
            }

            Hide();
            UserID = _dbContext.Users?.FirstOrDefault(e => e.Username == user.Username && e.PasswordHash == user.PasswordHash)?.Id;
            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual bool ActionClick(User user, out string message)
        {
            message = "The class is the parent of the form without implementation.";
            return false;
        }

    }
}
