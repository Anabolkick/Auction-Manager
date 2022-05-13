using System;

namespace AuctionLibrary
{
    public abstract class Request
    {
        private static int _globalId;
        public int Id { get; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDone { get; private set; }

        public event Action OnDone = delegate{};

        protected Request(double price, int count)
        {
            Price = price;
            Count = count;
            Id = _globalId;
            _globalId++;
        }

        public virtual void Done()
        {
            IsDone = true;
            OnDone();
        }

    }
}

