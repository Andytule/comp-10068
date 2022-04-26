using System;

namespace Problem4
{
    public class BidderObserver
    {     
        public decimal MaxSpendAmount { get; set; }
        
        public AuctioneerSubject auctioneer;

        public Item receivedItem;

        public decimal currentItemHighBid;
        public string currentBidItem;
        public BidderObserver lastHighestBidder;

        public BidderObserver(decimal maxSpendAmount, AuctioneerSubject auctioneer)
        {
            MaxSpendAmount = maxSpendAmount;
            this.auctioneer = auctioneer;
        }

        public void notifyItem(string name, decimal amount)
        {
            currentBidItem = name;
            currentItemHighBid = amount;
        }

        public void notifyHighBid(decimal amount)
        {
            currentItemHighBid = amount;
        }

        public void notifyHighBidder(BidderObserver b)
        {
            lastHighestBidder = b;
        }

        public void register()
        {
            auctioneer.registerBidder(this);
        }

        public void unregister()
        {
            auctioneer.unregisterBidder(this);
        }

        public void bid(decimal amount)
        {
            if (currentItemHighBid <= MaxSpendAmount)
            {
                auctioneer.bidOnItem(this, amount);
            }
            else
            {
                Console.WriteLine("Cannot bid, current high bid is above your max spend amount");
            }
        }


    }
}
