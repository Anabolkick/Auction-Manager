namespace AuctionLibrary
{
    public class BuyRequest : Request
    {
        public User Buyer { get; }
        public int SellRequestId { get; }

        public BuyRequest(double price, int count, User buyer,int sellRequestId) : base(price, count)
        {
            SellRequestId = sellRequestId;
            Buyer = buyer;
        }
    }
}
