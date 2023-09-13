using Core.Components;
using MaterialSkin.Controls;

namespace MoneyApp
{
    public partial class MoneyAppForm : MaterialForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly User _user;

        public MoneyAppForm(IServiceProvider serviceProvider, User user)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _user = user;
        }
    }
}
