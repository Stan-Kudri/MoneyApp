using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Db;
using Core.Service;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using MoneyApp.Model.UserItem;

namespace MoneyApp.AdditionalForms
{
    public partial class AccountLogin : MaterialForm
    {
        private readonly ActionsWithAccount _actionsWithAccount;
        private readonly IMessageBox _messageBox;
        private readonly AppDbContext _dbContext;
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public AccountLogin(ActionsWithAccount actionsWithAccount, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            if (actionsWithAccount.IsLogin == false)
            {
                throw new ArgumentException("Invalid action passed.");
            }

            if (actionsWithAccount.Value == ActionsWithAccount.Input)
            {
                tbConfirmationPass.Visible = false;
            }

            _serviceProvider = serviceProvider;
            _actionsWithAccount = actionsWithAccount;
            btnAction.Text = actionsWithAccount.Name;

            _messageBox = serviceProvider.GetRequiredService<IMessageBox>();
            _dbContext = serviceProvider.GetRequiredService<AppDbContext>();

            _userService = new UserService(_dbContext, _messageBox);

        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            var user = new UserModel(tbLogin.Text, tbPassword.Text).ToUser();

            if (!IsFieldsFilled())
            {
                _messageBox.ShowWarning("Fill in the input fields.");
            }
            else if (!user.IsPasswordFormat(tbPassword.Text))
            {
                _messageBox.ShowWarning("The password is not in the correct format.");
                return;
            }


            if (_actionsWithAccount == ActionsWithAccount.Create)
            {
                if (!EqualsPassword())
                {
                    _messageBox.ShowWarning("The entered passwords do not match.");
                    return;
                }
                else if (!_userService.IsFreeUsername(user))
                {
                    _messageBox.ShowWarning("Username Busy, please select another username");
                    return;
                }
            }
            else if (_actionsWithAccount == ActionsWithAccount.Input)
            {
                if (!user.IsPasswordFormat(tbPassword.Text))
                {
                    _messageBox.ShowWarning("The password is not in the correct format.");
                    return;
                }
                else if (_userService.IsUserData(user))
                {
                    _messageBox.ShowWarning("Invalid username or password.");
                    return;
                }

            }

            _userService.Add(user);
            var moneyAppForm = new MoneyAppForm(_serviceProvider, user);
            Visible = false;

            if (moneyAppForm.ShowDialog() != DialogResult.OK)
            {
                Visible = true;
                return;
            }

        }

        private bool EqualsPassword() => tbPassword.Text.Equals(tbConfirmationPass.Text);

        private bool IsFieldsFilled() => _actionsWithAccount == ActionsWithAccount.Create ? IsCreateFieldsFilled() : IsInputFieldsFilled();

        private bool IsCreateFieldsFilled() => tbConfirmationPass.Text.Length > 1 && tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0;

        private bool IsInputFieldsFilled() => tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0;
    }
}
