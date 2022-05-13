namespace AuctionLibrary
{
    public class User
    {
        private static int _globalId;
        public int Id { get; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public SellRequest[] SellRequests { get; set; }
        public BuyRequest[] BuyRequests { get; set; }

        public User(string login, string email, string password)
        {
            Login = login;
            Password = password;
            Email = email;
            Id = _globalId;
            _globalId++;
        }
    }

    
}
