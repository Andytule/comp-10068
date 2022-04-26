using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum FormFactor
    {
        pITX,
        nITX,
        mITX,
        mATX,
        ATX
    }

    public class Motherboard
    {
        int MemorySlots;
        int PowerConsumption;
        int PCISlots;
        FormFactor FormFactor;
        int HDDLimit;
        public CPU CPU { get; set; }
        public Memory Memory { get; set; }
        public GPU GPU { get; set; }

        public Motherboard(int memorySlots, int powerConsumption, int pciSlots, 
            FormFactor formFactor, int hddLimit, CPU cpu, Memory memory, GPU gpu)
        {
            if (memorySlots <= 1 || memorySlots > 4)
            {
                throw new ArgumentOutOfRangeException("memorySlots", "Motherboard must have between 1 and 4 memory slots");
            }
           

            if (powerConsumption <= 0)
            {
                throw new ArgumentOutOfRangeException("powerConsumption", "Power consumption must be greater than 0");
            }

            if (pciSlots <= 1 || pciSlots > 12)
            {
                throw new ArgumentOutOfRangeException("pciSlots", "Motherboard must have between 1 and 12 PCI slots");
            }

            if (hddLimit < 0 || hddLimit > 12) {
                throw new ArgumentOutOfRangeException("hddLimit", "Hard drive limit must be between 0 and 12");
            }
            MemorySlots = memorySlots;
            PowerConsumption = powerConsumption;
            PCISlots = pciSlots;
            FormFactor = formFactor;
            HDDLimit = hddLimit;
            CPU = cpu;
            GPU = gpu;
            Memory = memory;
        }

        public override string ToString()
        {
            return $"Motherboard: \t\n{CPU}\n{Memory}\n{GPU}\n{HDDLimit}, {FormFactor}, {PCISlots}, {PowerConsumption}, {MemorySlots}";
        }
    }
}
