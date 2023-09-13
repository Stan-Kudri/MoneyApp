using Core.Components.Message;
using Core.Service;
using MaterialSkin;
using Microsoft.Extensions.DependencyInjection;
using MoneyApp.AdditionalForms;
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
                .AddScoped<IMessageBox, MessageBoxProvider>()
                .AddScoped<StartupForm>();

            var container = serviceCollection.BuildServiceProvider(new ServiceProviderOptions
            {
                ValidateOnBuild = true,
                ValidateScopes = true,
            });

            using var scope = container.CreateScope();

            var startupForm = scope.ServiceProvider.GetRequiredService<StartupForm>();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(startupForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo700, Primary.BlueGrey700, Primary.Blue800, Accent.Indigo700, TextShade.WHITE);
            Application.Run(startupForm);
        }
    }
}