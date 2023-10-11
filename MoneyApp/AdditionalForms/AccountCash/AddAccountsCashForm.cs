using Core.Components.Message;
using Core.Db;

namespace MoneyApp.AdditionalForms.AccountCash
{
    public class AddAccountsCashForm : AccountCashForm
    {
        public AddAccountsCashForm(IServiceProvider serviceProvider, IMessageBox messageBox, AppDbContext dbContext)
            : base(serviceProvider, messageBox, dbContext)
        {
        }

        public void Initialize(Guid userId) => _userId = userId;
    }
}
