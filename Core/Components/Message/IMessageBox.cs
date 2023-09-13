namespace Core.Components.Message
{
    public interface IMessageBox
    {
        public void ShowInfo(string message);

        public void ShowWarning(string message);

        public void ShowError(string message);
    }
}
