using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Car : Toy
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        public Car(string make, string model, int numberOfWheels, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight) 
            : base(cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight)
        {
            Make = make;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        public void openDoors()
        {

        }

        public void driveForward()
        {

        }

    }
}
