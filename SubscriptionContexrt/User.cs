using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class User : Base
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}