using System;
using System.Collections.Generic;

namespace AuctionLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<SellRequest> SellRequests { get; set; }
        public List<BuyRequest> BuyRequests { get; set; }

        public User()
        {
          
        }
        public User(string login, string email, string password)
        {
            Login = login;
            Password = password;
            Email = email;
            SellRequests = new List<SellRequest>();
            BuyRequests = new List<BuyRequest>();
        }
    }

    
}
