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

        public Range(int min, int max, double cumulativeDistributionValue)
        {
            this.min = min;
            this.max = max;
            this.cumulativeDistributionValue = cumulativeDistributionValue;
        }

    }
}
