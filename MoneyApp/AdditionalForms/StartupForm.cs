using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
using MoneyApp.AdditionalForms.Account;

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

        public bool HasBeenLogIn { get; private set; } = false;

        public Guid? UserId { get; private set; }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            using var loginForm = _serviceProvider.GetRequiredService<Login>();
            ShowFormLogIn(loginForm);
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            using var loginForm = _serviceProvider.GetRequiredService<Registration>();
            ShowFormLogIn(loginForm);
        }

        private void ShowFormLogIn(AccountLoginForm accountLogin)
        {
            Hide();
            if (accountLogin.ShowDialog() == DialogResult.Cancel)
            {
                Show();
                return;
            }

            HasBeenLogIn = true;
            UserId = accountLogin.UserID != Guid.Empty ? accountLogin.UserID : throw new Exception("Empty ID");
            Close();
        }
    }
}
