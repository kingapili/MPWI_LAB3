using System;

using RandomGenerators.Classes;

namespace RandomGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            InverseCumulativeDistributionMethod generator = new InverseCumulativeDistributionMethod();
            for (int i=0; i < 10; ++i)
            {
                Console.WriteLine(
                    generator
                        .RandRange()
                        .RandNumber()
                    );
            }


            EliminationMethod tupleGenerator = new EliminationMethod(10);
            tupleGenerator
                .RandTuples()
                .PrintRandNumbers();
        }
    }
}
