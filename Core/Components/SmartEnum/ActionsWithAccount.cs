using Ardalis.SmartEnum;

namespace Core.Components.SmartEnum
{
    public class ActionsWithAccount : SmartEnum<ActionsWithAccount>
    {
        public readonly static ActionsWithAccount Unknown = new ActionsWithAccount("Unknown", 0, false);
        public readonly static ActionsWithAccount Registration = new ActionsWithAccount("Registration", 1, true);
        public readonly static ActionsWithAccount LogIn = new ActionsWithAccount("Login", 2, true);

        public ActionsWithAccount(string name, int value, bool isLogin) : base(name, value)
        {
            IsLogin = isLogin;
        }

        public bool IsLogin { get; }
    }
}
