using System;

namespace AuctionLibrary
{
    public class SellRequest : Request
    {
        public string Product { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public SellRequest(double price, int count) : base(price, count)
        {
        }
        public SellRequest(string product, double price, int count, User seller) : base(price, count)
        {
            Product = product;
            Seller = seller;
            SellerId = seller.Id;
        }
    }
}
