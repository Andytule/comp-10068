using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Dollhouse : Toy
    {
    
        public int Stories { get; set; }
        public bool HasGarage { get; set; }
        public bool FurnitureIncluded{ get; set; }

        public Dollhouse(int stories, bool hasGarage, bool furnitureIncluded, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
           : base(cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight)
        {
            Stories = stories;
            HasGarage = hasGarage;
            FurnitureIncluded = furnitureIncluded;
        }

        public void openDollhouse()
        {

        }

        public void insertDoll()
        {

        }
    }
}
