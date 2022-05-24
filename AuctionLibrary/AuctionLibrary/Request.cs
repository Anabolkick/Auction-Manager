using System;
using System.ComponentModel.DataAnnotations;

namespace AuctionLibrary
{
    public abstract class Request
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDone { get; private set; }

        public event Action OnDone = delegate{};

        protected Request()
        {

        }

        protected Request(double price, int count)
        {
            Price = price;
            Count = count;
        }

        public virtual void Done()
        {
            IsDone = true;
            OnDone();
        }

    }
}

