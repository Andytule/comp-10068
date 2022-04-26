using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Computer
    {
        public HDD HDD { get; set; }
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public Memory Memory { get; set; }
        public GPU GPU { get; set; }
        public Case Case { get; set; }

        public Computer()
        {

        }
        

        public string Show()
        {
            return $"Computer: {Case} \n{HDD} \n{Motherboard}";
        }
    }
}
