using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class ComputerBuilder : IComputerBuilder<Computer>
    {
        private readonly Computer computer;

        public ComputerBuilder()
        {
            computer = new Computer();
        }

        public IComputerBuilder<Computer> AddCase(Case @case)
        {
            this.computer.Case = @case;
            return this;
        }

        public IComputerBuilder<Computer> AddHardDrive(HDD hdd)
        {
            computer.HDD = hdd;
            return this;
        }

        public IComputerBuilder<Computer> AddMotherboard(Motherboard motherboard)
        {
            computer.Motherboard = motherboard;
            computer.CPU = motherboard.CPU;
            computer.GPU = motherboard.GPU;
            computer.Memory = motherboard.Memory;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }

    }
}
