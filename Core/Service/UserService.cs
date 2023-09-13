using Core.Components;
using Core.Components.Message;
using Core.Db;

namespace Core.Service
{
    public class UserService
    {
        private readonly AppDbContext _db;
        private readonly IMessageBox _messageBox;

        public UserService(AppDbContext appDbContext, IMessageBox messageBox)
        {
            _db = appDbContext;
            _messageBox = messageBox;
        }

        public User? GetUser(User user)
        {
            var userFromDatabase = _db.Users.Where(e => e.Username == user.Username && e.PasswordHash == user.PasswordHash).FirstOrDefault();

            if (userFromDatabase != null)
            {
                _messageBox.ShowWarning("User data is incorrect.");
                return null;
            }

            return userFromDatabase;
        }

        public void Add(User user)
        {
            var duplicateItem = _db.Users.Where(e => e.Username == user.Username).Take(1).Count();

            if (user != null && duplicateItem != 1)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
        }

        public void Delete(Guid idUser)
        {
            var user = _db.Users.FirstOrDefault(e => e.Id == idUser);
            if (user == null)
            {
                return;
            }

            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public bool IsFreeUsername(User user) =>
            _db.Users.FirstOrDefault(e => e.Username == user.Username) == null;

        public bool IsUserData(User user) =>
            _db.Users.FirstOrDefault(e => e.Username == user.Username && e.PasswordHash == user.PasswordHash) == null;
    }
}
