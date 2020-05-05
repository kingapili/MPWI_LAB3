using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerators.Classes
{
    class InverseCumulativeDistributionMethod
    {
        private static Range[] ranges;
        private Range randomlyChosenRange;
        private double randomValue;
        private int numberOfRandsToGenerate;

        public InverseCumulativeDistributionMethod(int numberOfRandsToGenerate)
        {
            this.numberOfRandsToGenerate = numberOfRandsToGenerate;
            ranges = new Range[]{
                new Range(0, 1, 0.2),
                new Range(1, 2, 0.6),
                new Range(2, 3, 0.9),
                new Range(3, 4, 1),
            };
        }

        public InverseCumulativeDistributionMethod ClearRangesCounters()
        {
            foreach(Range range in ranges)
            {
                range.ClearCounter();
            }
            return this;
        }

        public InverseCumulativeDistributionMethod RandRange()
        {
            Random rnd = new Random();
            double randomCumulativeDistribution = rnd.NextDouble();

            foreach (Range range in ranges)
            {
                if (randomCumulativeDistribution <= range.cumulativeDistributionValue)
                {
                    randomlyChosenRange = range;
                    range.IncreseCounter();
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

        public InverseCumulativeDistributionMethod PrintRandNumbers()
        {
            for (int i = 0; i < numberOfRandsToGenerate; ++i)
            {
                Console.WriteLine(
                    this
                        .RandRange()
                        .RandNumber()
                    );
            }
            return this;
        }

        public void PrintRangeCouters()
        {
            foreach (Range range in ranges)
            {
                range.PrintCounter();
            }
        }

    }
}
