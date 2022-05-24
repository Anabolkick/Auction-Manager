using System.Collections.Generic;

namespace AuctionLibrary
{
    public static class DealManager
    {
        public static List<BuyRequest> BuyRequests = new();
        public static List<SellRequest> SellRequests = new();
        public static List<SellRequest> ClosedSellRequests = new();
        public static List<BuyRequest> ClosedBuyRequests = new();

        public static void MakeDeals()
        {
            foreach (var sellRequest in SellRequests)
            {
                List<BuyRequest> currBuyRequests = new List<BuyRequest>();

                foreach (var buyRequest in BuyRequests)
                {
                    if (sellRequest.Id == buyRequest.TargetSellRequest.Id)
                    {
                        currBuyRequests.Add(buyRequest);
                    }
                }

                currBuyRequests.Sort((x, y) => y.Price.CompareTo(x.Price));
                foreach (var buyRequest in currBuyRequests)
                {
                    if (buyRequest.Price < sellRequest.Price)
                    {
                        break;
                    }
                    if (sellRequest.Count < buyRequest.Count)
                    {
                        continue;
                    }

                    sellRequest.Count -= buyRequest.Count;
                    buyRequest.Done();
                    ClosedBuyRequests.Add(buyRequest);

                    if (sellRequest.Count <= 0)
                    {
                        sellRequest.Done();
                        ClosedSellRequests.Add(sellRequest);
                        foreach (var currRequest in currBuyRequests)
                        {
                            ClosedBuyRequests.Add(currRequest);
                        }
                        break;
                    }
                }
            }
        }

        public static void DeleteClosedRequests()
        {
            foreach (var buyRequest in ClosedBuyRequests)
            {
                BuyRequests.Remove(buyRequest);
            }

            foreach (var sellRequest in ClosedSellRequests)
            {
                SellRequests.Remove(sellRequest);
            }
            ClosedSellRequests = new List<SellRequest>();
            ClosedBuyRequests = new List<BuyRequest>();
        }

    }
}
