using Core.Components.SmartEnum;
using MaterialSkin.Controls;

namespace MoneyApp.AdditionalForms
{
    public partial class StartupForm : MaterialForm
    {
        private readonly IServiceProvider _serviceProvider;

        public StartupForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ShowFormLogIn(ActionsWithAccount.Input);
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            ShowFormLogIn(ActionsWithAccount.Create);
        }

        private void ShowFormLogIn(ActionsWithAccount actionsWithAccount)
        {
            var logInForm = new AccountLogin(actionsWithAccount, _serviceProvider);
            Visible = false;
            if (logInForm.ShowDialog() != DialogResult.OK)
            {
                Visible = true;
                return;
            }

        }
    }
}
