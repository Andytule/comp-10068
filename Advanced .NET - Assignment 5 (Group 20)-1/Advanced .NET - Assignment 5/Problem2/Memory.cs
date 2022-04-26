using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum MemoryType
    {
        DDR1,
        DDR2,
        DDR3,
        DDR4
    }
    public class Memory
    {
        int ReadSpeed;
        int WriteSpeed;
        MemoryType Type;
        int Size;

        public Memory(int readSpeed, int writeSpeed, MemoryType type, int size)
        {
            if (readSpeed <= 0)
            {
                throw new ArgumentOutOfRangeException("readSpeed", "Read speed must be greater than 0");
            }

            if (writeSpeed <= 0)
            {
                throw new ArgumentOutOfRangeException("writeSpeed", "Write speed must be greater than 0");
            }
            if (size <= 0 || size >= 64)
            {
                throw new ArgumentOutOfRangeException("size", "RAM size must be greater than 0GB and less than 64GB");
            }
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            Type = type;
            Size = size;
        }

        public override string ToString()
        {
            return $"Memory: {Size}, {Type}, {ReadSpeed}, {WriteSpeed}";
        }

    }
}
