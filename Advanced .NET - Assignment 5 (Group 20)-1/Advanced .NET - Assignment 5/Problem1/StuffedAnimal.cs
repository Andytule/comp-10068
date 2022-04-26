using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class StuffedAnimal : Toy
    {
        public string Stuffing { get; set; }
        public string Animal { get; set; }
        public bool MakesNoise { get; set; }

        public StuffedAnimal(string stuffing, string animal, bool makesNoise, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight) : base(cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight)
        {
            Stuffing = stuffing;
            Animal = animal;
            MakesNoise = makesNoise;
        }

        public void flopOver()
        {

        }

        public void squish()
        {

        }
    }
}
