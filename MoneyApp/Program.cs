using Core.Components.Message;
using Core.Service;
using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using MoneyApp.AdditionalForms;
using MoneyApp.AdditionalForms.Account;
using MoneyApp.AdditionalForms.AccountCash;
using MoneyApp.Item;
using MoneyApp.Message;

namespace MoneyApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection()
                .AddSingleton(new FileDbContextFactory("DbUser.db"))
                .AddScoped(e => e.GetRequiredService<FileDbContextFactory>().Create())
                .AddScoped<UserService>()
                .AddTransient<LoginForm>()
                .AddTransient<RegistrationForm>()
                .AddTransient<MoneyAppForm>()
                .AddScoped<IMessageBox, MessageBoxProvider>()
                .AddTransient<StartupForm>()
                .AddScoped<WalletService>()
                .AddTransient<AddAccountsCashForm>()
                .AddTransient<EditAccountCashForm>();

            var container = serviceCollection.BuildServiceProvider(new ServiceProviderOptions
            {
                ValidateOnBuild = true,
                ValidateScopes = true,
            });

            using var scope = container.CreateScope();
            AppDomain.CurrentDomain.UnhandledException += (_, e) => OnUnhandledException(scope.ServiceProvider, e);
            var startupForm = scope.ServiceProvider.GetRequiredService<StartupForm>();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(startupForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo700, Primary.BlueGrey700, Primary.Blue800, Accent.Indigo700, TextShade.WHITE);

            Application.Run(startupForm);

            if (!startupForm.HasBeenLogIn)
            {
                return;
            }

            var userId = startupForm.UserId;
            var moneyAppForm = scope.ServiceProvider.GetRequiredService<MoneyAppForm>();
            moneyAppForm.Initialize(userId);
            Application.Run(moneyAppForm);
        }


        private static void OnUnhandledException(IServiceProvider provider, UnhandledExceptionEventArgs e)
        {
            var messageBox = provider.GetRequiredService<IMessageBox>();
            string errorMessage = "Unhandled exception:" + Environment.NewLine + e.ExceptionObject;
            messageBox.ShowError(errorMessage);
        }
    }
}