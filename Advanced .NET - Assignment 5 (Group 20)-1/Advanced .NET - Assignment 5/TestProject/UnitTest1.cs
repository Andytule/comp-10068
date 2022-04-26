//Group 20: Andy Le, Sam Gershkovich, Cam Randall

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;
using Problem1;
using Problem3;
using Problem4;
using Assignment5;

using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestComputerBuilder_InvalidArgument()
        {
            //arrange
            Case @case = new Case(10, 10, 10, 4, 4);
            CPU cpu = new CPU(3.6, Manufacturer.AMD, "AM4", 24, 8);
            Memory memory = new Memory(2400, 2400, MemoryType.DDR4, 16);
            //GPU negative fan count
            GPU gpu = new GPU(-1, 1.9, 8, 24);
            Motherboard motherboard = new Motherboard(4, 200, 3, FormFactor.ATX, 6, cpu, memory, gpu);

            ComputerDirector director = new ComputerDirector();
            ComputerBuilder builder = new ComputerBuilder();
            builder.AddCase(@case).AddMotherboard(motherboard);

            var computer = director.Construct(builder);

        }
    }

    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void TestDispatcher_MailDelivered()
        {
            //arrange
            Mailbox myMailbox = new Mailbox(new MailingInformation("Cameron", "234 Albion Road"));
            Mail newMail = new Mail(new MailingInformation("Cameron", "234 Albion Road"), new MailingInformation("Cameron", "234 Albion Road"), 5, 5, MailType.Package, false);
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.AddMailbox(myMailbox);
            //Act
            dispatcher.Handle(newMail);
            int mailBoxSize = myMailbox.GetSize();
            int expectedSize = 1;
            //Assert
            Assert.AreEqual(expectedSize, mailBoxSize);
        }
    }

    [TestClass]
    public class Problem4Test
    {
        [TestMethod]
        public void TestAuction_Broadcast()
        {
            //arrange
            Item someItem = new Item("Rolex", 1000, 1905);
            AuctioneerSubject auctioneer = new AuctioneerSubject();
            auctioneer.items.Push(someItem);
            BidderObserver obsv1 = new BidderObserver(2000, auctioneer);
            BidderObserver obsv2 = new BidderObserver(1500, auctioneer);
            obsv1.register();
            obsv2.register();

            //Act
            auctioneer.startBid();
            //Assert
            string expected = "Rolex";
            Assert.AreEqual(obsv1.currentBidItem, expected);
            Assert.AreEqual(obsv2.currentBidItem, expected);
        }

        [TestMethod]
        public void TestAuction_Unregister()
        {
            //arrange
            Item someItem = new Item("Rolex", 1000, 1905);
            AuctioneerSubject auctioneer = new AuctioneerSubject();
            auctioneer.items.Push(someItem);
            BidderObserver obsv1 = new BidderObserver(2000, auctioneer);
            BidderObserver obsv2 = new BidderObserver(1500, auctioneer);
            obsv1.register();
            obsv2.register();

            //Act
            auctioneer.startBid();
            obsv2.bid(1100);
            obsv1.bid(1500);
            obsv2.unregister();
            //Assert
            int expectedObservers = 1;
            int expectedPrice = 1500;
            Assert.AreEqual(auctioneer.bidders.Count, expectedObservers);
            Assert.AreEqual(auctioneer.highestBid, expectedPrice);
        }
    }
}
