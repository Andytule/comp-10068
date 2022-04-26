using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class GPU
    {
        int FanCount;
        double Speed;
        int VRAM;
        int CoreCount;

        public GPU(int fanCount, double speed, int vram, int coreCount)
        {
            if (fanCount <= 0 || fanCount > 4)
            {
                throw new ArgumentOutOfRangeException("fanCount", "Fan Count must be greater than 0 and less than 4");
            }

            if (speed <= 0 || speed >= 4000)
            {
                throw new ArgumentOutOfRangeException("speed", "Speed must be greater than 0 and less than 4000");
            }

            if (vram <= 0 || vram >= 24)
            {
                throw new ArgumentOutOfRangeException("vram", "VRAM must be greater than 0 and less than 24");
            }

            if (coreCount <= 0)
            {
                throw new ArgumentOutOfRangeException("coreCount", "CUDA core count must be greater than 0");
            }

            FanCount = fanCount;
            Speed = speed;
            VRAM = vram;
            CoreCount = coreCount;
        }

        public override string ToString()
        {
            return $"GPU: {Speed}, {VRAM}, {CoreCount}, {FanCount}";
        }
    }
}
