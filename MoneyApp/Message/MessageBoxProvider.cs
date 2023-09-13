using Core.Components.Message;

namespace MoneyApp.Message
{
    public class MessageBoxProvider : IMessageBox
    {
        public void ShowInfo(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public void ShowWarning(string message) => MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public void ShowError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
