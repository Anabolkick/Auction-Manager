using System;

namespace AuctionLibrary
{
    public class BuyRequest : Request
    {
        public User Buyer { get; set; }
        public int BuyerId { get; set; }
        public SellRequest TargetSellRequest { get; set; }
        public BuyRequest(double price, int count) : base(price, count)
        {
            
        }
        public BuyRequest(double price, int count, User buyer, SellRequest targetSellRequest) : base(price, count)
        {
            Buyer = buyer;
            TargetSellRequest = targetSellRequest;
            BuyerId = buyer.Id;
        }
    }
}
