using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerators.Classes
{
    class InverseCumulativeDistributionMethod
    {
        private static readonly Range[] ranges = {
            new Range(0, 1, 0.2),
            new Range(1, 2, 0.6),
            new Range(2, 3, 0.9),
            new Range(3, 4, 1),
        };

        private Range randomlyChosenRange;
        private double randomValue;

        public InverseCumulativeDistributionMethod RandRange()
        {
            Random rnd = new Random();
            double randomCumulativeDistribution = rnd.NextDouble();

            foreach (Range range in ranges)
            {
                if (randomCumulativeDistribution <= range.cumulativeDistributionValue)
                {
                    randomlyChosenRange = range;
                    break;
                }
            }
            return this;
        }

        public double RandNumber()
        {
            Random rnd = new Random();
            randomValue = rnd.NextDouble(); // rand number in range <0, 1)
            if (randomValue == 0.0) // change range to (0, 1>
                randomValue = 1.0;
            return randomValue * (randomlyChosenRange.max - randomlyChosenRange.min) + randomlyChosenRange.min; // scale range to (min, max>
        }
    }
}
