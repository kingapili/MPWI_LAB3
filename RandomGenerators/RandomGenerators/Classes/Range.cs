using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerators.Classes
{
    class Range
    {
        public double min; // lowerLimit
        public double max; //upperLimit
        public double cumulativeDistributionValue;
        public int numberOfRandsCounter;

        public Range(int min, int max, double cumulativeDistributionValue)
        {
            this.min = min;
            this.max = max;
            this.cumulativeDistributionValue = cumulativeDistributionValue;
            this.ClearCounter();
        }

        public void IncreseCounter()
        {
            this.numberOfRandsCounter += 1;
        }

        public void ClearCounter()
        {
            this.numberOfRandsCounter = 0;
        }

        public void PrintCounter()
        {
            Console.WriteLine("Range (" + min + ", " + max + ") - counter: " + numberOfRandsCounter);
        }

    }
}
