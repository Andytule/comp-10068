using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class RainbowStacker : Toy
    {
        public int RingCount { get; set; }
        public string RingMaterial { get; set; }
        public string StackShape { get; set; }

        public RainbowStacker(int ringCount, string ringMaterial, string stackShape, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
            : base(cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight)
        {
            RingCount = ringCount;
            RingMaterial = ringMaterial;
            StackShape = stackShape;
        }

        public void addRing()
        {

        }

        public void removeRing()
        {

        }
    }
}
