using System.Collections.Generic;
using System.Linq;
using AuctionLibrary;

namespace Auction_Manager
{
    public static class UserManager
    {
        public static void AddUser(User user)
        {
            using AppDbContext db = new AppDbContext();
            db.Users.Add(user);
            db.SaveChanges();
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
                AddUser(user);
                using AppDbContext db = new AppDbContext();
                var my_user = db.Users.FirstOrDefault(u => u.Login == login);
                return my_user;
            }
        }

        public static User Login(string login, string email, string password)
        {
            using AppDbContext db = new AppDbContext();
            var usersList = db.Users.ToList();
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
