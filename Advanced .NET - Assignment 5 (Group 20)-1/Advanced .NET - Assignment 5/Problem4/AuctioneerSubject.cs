using System;
using System.Collections.Generic;

namespace Problem4
{
    public class AuctioneerSubject
    {
        public List<BidderObserver> bidders;
        public Stack<Item> items;

        public decimal highestBid;
        public BidderObserver highestBidder;
        public Item currentItem;

        public AuctioneerSubject()
        {
            bidders = new List<BidderObserver>();
            items = new Stack<Item>();
        }

        public void startBid()
        {
            currentItem = items.Pop();
            highestBid = currentItem.StartingPrice;
            notifyBidders("item");
        }

        public void registerBidder(BidderObserver b)
        {
            bidders.Add(b);
        }

        public void unregisterBidder(BidderObserver b)
        {
            bidders.Remove(b);
        }

        public void notifyBidders(string type)
        {
            switch (type)
            {
                case "item":

                    foreach (BidderObserver b in bidders){
                        b.notifyItem(currentItem.Name, currentItem.StartingPrice);
                    }
                    Console.WriteLine($"{currentItem.Name}, {currentItem.StartingPrice}");
                    break;
                case "highBid":

                    foreach (BidderObserver b in bidders) {
                        b.notifyHighBid(highestBid);
                    }
                    break;
                case "closed":

                    foreach (BidderObserver b in bidders){
                        b.notifyHighBidder(highestBidder);
                    }
                    break;
            }          
        }

        public void bidOnItem(BidderObserver b, decimal amount)
        {
            if (amount > highestBid)
            {
                highestBid = amount;
                highestBidder = b;
                currentItem.TimesBidOn++;

                notifyBidders("highBid");

                if (currentItem.TimesBidOn == 5)
                {
                    b.receivedItem = currentItem;
                    unregisterBidder(b);
                    startBid();
                }
            }
        }
    }
}
