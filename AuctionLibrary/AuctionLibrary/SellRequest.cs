namespace AuctionLibrary
{
    public class SellRequest : Request
    {
        public Product Product { get; }
        public User Seller { get; }

        public SellRequest(Product product, double price, int count, User seller) : base(price, count)
        {
            Product = product;
            Seller = seller;
        }
    }
}
