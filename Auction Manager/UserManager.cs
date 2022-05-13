using System.Collections.Generic;
using AuctionLibrary;

namespace Auction_Manager
{
    public static class UserManager
    {
        private static List<User> usersList = new();

        public static void AddUser(User user)
        {
            usersList.Add(user);
        }
        public static User Register(string login, string email, string password)
        {
            if (login.Length < 1 || email.Length < 1 || password.Length < 1)
            {
                return null;
            }
            else
            {
                User user = new User(login, email, password);
                usersList.Add(user);
                return user;
            }
        }

        public static User Login(string login, string email, string password)
        {
            foreach (var user in usersList)
            {
                if (user.Login == login && user.Password == password || user.Email == email && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
