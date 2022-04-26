using System;

namespace Problem1
{
    public abstract class Toy
    {
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ManufacturingCompany { get; set; }
        public int YearOfManufacturing { get; set; }
        public int MinimumAgeLimit { get; set; }
        public int MaximumAgeLimit { get; set; }
        public bool ContainsChockingHazard { get; set; }
        public float Weight { get; set; }

        public Toy(decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
        {
            Cost = cost;
            Description = description;
            Name = name;
            ManufacturingCompany = manufacturingCompany;
            YearOfManufacturing = yearOfManufacturing;
            MinimumAgeLimit = minimumAgeLimit;
            MaximumAgeLimit = maximumAgeLimit;
            ContainsChockingHazard = containsChockingHazard;
            Weight = weight;
        }
    }


}
