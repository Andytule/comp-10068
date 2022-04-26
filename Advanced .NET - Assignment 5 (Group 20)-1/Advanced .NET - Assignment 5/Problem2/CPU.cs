using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{

    public enum Manufacturer
    {
        AMD,
        Intel
    }

    public class CPU
    {
        public double Speed;
        Manufacturer Manufacturer;
        private string SocketType;
        private int CacheSize;
        private int CoreCount;

        public CPU(double speed, Manufacturer manufacturer, string socketType, int cacheSize, int coreCount)
        {
            if (speed <= 0 || speed >= 6)
            {
                throw new ArgumentOutOfRangeException("speed", "CPU speed must be greater than 0 and less than 6 GHz");
            }
            if (cacheSize <= 0) {
                throw new ArgumentOutOfRangeException("cacheSize", "Cache Size must be greater than 0");
            }

            if (coreCount <= 0 || coreCount > 24)
            {
                throw new ArgumentOutOfRangeException("coreCount", "Core Count must be greater than 0 and less than 24");
            }

            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType;
            CacheSize = cacheSize;
            CoreCount = coreCount;


        }


        public override string ToString()
        {
            return $"CPU: {Speed}, {CoreCount}, {Manufacturer}, {SocketType}, {CacheSize}";
        }
    }

    
}
