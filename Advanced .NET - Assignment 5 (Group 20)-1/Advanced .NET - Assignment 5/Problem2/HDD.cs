using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum StorageType
    {
        SSD,
        HDD
    }
    public class HDD
    {
        int Capacity;
        StorageType Type;
        int ReadSpeed;
        int WriteSpeed;

        public HDD(int capacity, StorageType type, int readSpeed, int writeSpeed)
        {
            if (readSpeed <= 0)
            {
                throw new ArgumentOutOfRangeException("readSpeed", "Read speed must be greater than 0");
            }

            if (writeSpeed <= 0)
            {
                throw new ArgumentOutOfRangeException("writeSpeed", "Write speed must be greater than 0");
            }

            if (capacity <= 0 || capacity >= 4)
            {
                throw new ArgumentOutOfRangeException("capacity", "Capacity must be greater than 0 and less than 4");
            }
            Capacity = capacity;
            Type = type;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }

        public override string ToString()
        {
            return $"HDD: {Capacity}, {Type}, {ReadSpeed}, {WriteSpeed}";
        }
    }
}
