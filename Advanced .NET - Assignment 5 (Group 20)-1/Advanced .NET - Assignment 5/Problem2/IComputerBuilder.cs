using System;

namespace Problem2
{
    public interface IComputerBuilder<out T> where T : Computer
    {
        IComputerBuilder<T> AddHardDrive(HDD hdd);
        IComputerBuilder<T> AddMotherboard(Motherboard motherboard);
        IComputerBuilder<T> AddCase(Case @case);

        T Build();

    }
}
