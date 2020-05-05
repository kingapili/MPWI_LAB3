using System;

using RandomGenerators.Classes;

namespace RandomGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            InverseCumulativeDistributionMethod generator = new InverseCumulativeDistributionMethod(10000);
            generator
                .ClearRangesCounters()
                .PrintRandNumbers()
                .PrintRangeCouters();


            EliminationMethod tupleGenerator = new EliminationMethod(10000);
            tupleGenerator
                .RandTuples()
                .PrintRandNumbers();
        }
    }
}
