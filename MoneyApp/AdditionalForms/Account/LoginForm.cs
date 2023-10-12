using Core.Components;
using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Db;
using Core.Service;

namespace MoneyApp.AdditionalForms.Account
{
    public class LoginForm : AccountLoginForm
    {
        public LoginForm(
            IServiceProvider serviceProvider,
            IMessageBox messageBox,
            AppDbContext appDbContext,
            UserService userService) : base(serviceProvider, messageBox, appDbContext, userService)
        {
            tbConfirmationPass.Visible = false;
        }

        protected override ActionsWithAccount ActionsWithAccount => ActionsWithAccount.LogIn;

        protected override bool Validate(User user, out string message)
        {
            if (!IsInputFieldsFilled())
            {
                message = "Fill in the input fields.";
                return false;
            }
            else if (!user.IsPasswordFormat(tbPassword.Text))
            {
                message = "The password is not in the correct format.";
                return false;
            }
            else if (_userService.IsUserData(user))
            {
                message = "Invalid username or password.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private bool IsInputFieldsFilled() => tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0;
    }
}
