using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyBlanket
{
    internal class Katte
    {

        public Katte (string navn, int føsår, string mønster, string farve)
        {
            Name = navn;
            YoB = føsår;
            Pattern = mønster;
            Color = farve;
            
        }
        public string Name { get; set; }
        public int YoB { get; set; }
        public string Pattern { get; set; }
        public string Color { get; set; }

        public string GetInfo()
        {
            return $"{Name} was born {YoB}, is {Color} and has a {Pattern} pattern.";
        }

        
    }
}
