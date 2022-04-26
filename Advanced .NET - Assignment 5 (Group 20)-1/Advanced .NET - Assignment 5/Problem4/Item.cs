using System;

namespace Problem4
{
    public class Item
    {
        public string Name { get; set; }
        public decimal StartingPrice { get; set; }
        public int YearOfCreation { get; set; }
        public int TimesBidOn { get; set; }

        public Item(string name, decimal startingPrice, int yearOfCreation)
        {
            Name = name;
            StartingPrice = startingPrice;
            YearOfCreation = yearOfCreation;
            TimesBidOn = 0;
        }
    }


}