namespace AuctionLibrary
{
    public class Product
    {
        private static int _globalId;
        public int Id { get; }
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
            Id = _globalId;
            _globalId++;
        }

    }
}
