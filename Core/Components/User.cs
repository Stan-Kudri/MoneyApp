using Core.Components.UserItem;

namespace Core.Components
{
    public class User : Entity
    {
        public int MinLength = 8;

        public User()
        {
        }

        public User(string username, string password, List<Wallet>? wallets = null)
            : this(username, password, Guid.NewGuid(), wallets)
        {
        }

        public User(string username, string password, Guid id, List<Wallet>? wallets = null)
        {
            if (username == null || username == string.Empty || username.Length < 1)
            {
                throw new ArgumentException("The username is not in the correct format.", username);
            }
            if (password == null || password == string.Empty || !IsPasswordFormat(password))
            {
                throw new ArgumentException("The username is not in the correct format.", username);
            }

            Username = username;
            PasswordHash = password;
            Id = id;
            Wallets = wallets;
        }

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public List<Wallet>? Wallets { get; set; }

        public bool IsPasswordFormat(string password)
        {
            if (password.Length < MinLength ||
                password.ToArray().Where(x => char.IsPunctuation(x) == true).Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
