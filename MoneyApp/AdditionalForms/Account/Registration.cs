using Core.Components;
using Core.Components.Message;
using Core.Components.SmartEnum;
using Core.Db;
using Core.Service;

namespace MoneyApp.AdditionalForms.Account
{
    public class Registration : AccountLoginForm
    {
        protected override ActionsWithAccount ActionsWithAccount => ActionsWithAccount.Registration;

        public Registration(
            IServiceProvider serviceProvider,
            IMessageBox messageBox,
            AppDbContext appDbContext,
            UserService userService) : base(serviceProvider, messageBox, appDbContext, userService)
        {
        }

        protected override bool ActionClick(User user, out string message)
        {
            if (!IsCreateFieldsFilled())
            {
                message = "Fill in the input fields.";
                return false;
            }
            else if (!user.IsPasswordFormat(tbPassword.Text))
            {
                message = "The password is not in the correct format.";
                return false;
            }
            else if (!EqualsPassword())
            {
                message = "The entered passwords do not match.";
                return false;
            }
            else if (!_userService.IsFreeUsername(user))
            {
                message = "Username Busy, please select another username";
                return false;
            }

            message = string.Empty;
            _userService.Add(user);
            return true;
        }

        private bool IsCreateFieldsFilled() => tbConfirmationPass.Text.Length > 1 && tbLogin.Text.Length > 0 && tbPassword.Text.Length > 0;

        private bool EqualsPassword() => tbPassword.Text.Equals(tbConfirmationPass.Text);
    }
}
