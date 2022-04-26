using System;

namespace Problem1
{
    public class ToyFactory
    {
        public Car CreateCar(string make, string model, int numberOfWheels, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
        {
            return new Car(make, model, numberOfWheels, cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight);
        }

        public StuffedAnimal CreateStuffedAnimal(string stuffing, string animal, bool makesNoise, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
        {
            return new StuffedAnimal(stuffing, animal, makesNoise, cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight);
        }

        public Dollhouse CreateDollhouse(int stories, bool hasGarage, bool furnitureIncluded, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
        {
            return new Dollhouse(stories, hasGarage, furnitureIncluded, cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight);
        }

        public RainbowStacker CreateRainbowStacker(int ringCount, string ringMaterial, string stackShape, decimal cost, string description, string name, string manufacturingCompany, int yearOfManufacturing, int minimumAgeLimit, int maximumAgeLimit, bool containsChockingHazard, float weight)
        {
            return new RainbowStacker(ringCount, ringMaterial, stackShape, cost, description, name, manufacturingCompany, yearOfManufacturing, minimumAgeLimit, maximumAgeLimit, containsChockingHazard, weight);
        }

    }
}
